using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CurrencyConverter
{
    public partial class CurrencyConverterForm : Form
    {
        private Dictionary<string, string> currencies = new Dictionary<string, string>
        {
            { "USD", "US Dollar" },
            { "EUR", "Euro" },
            { "GBP", "British Pound" },
            { "JPY", "Japanese Yen" },
            { "TRY", "Turkish Lira" },
            { "CAD", "Canadian Dollar" },
            { "AUD", "Australian Dollar" },
            { "CHF", "Swiss Franc" },
            { "CNY", "Chinese Yuan" },
            { "RUB", "Russian Ruble" }
        };

        private HttpClient client = new HttpClient();
        // Yeni API URL'i
        private const string API_URL = "https://open.er-api.com/v6/latest/";

        public CurrencyConverterForm()
        {
            InitializeComponent();
            InitializeCurrencyComboBoxes();

            
            textBoxAmount.Text = "1";
        }

        private void InitializeCurrencyComboBoxes()
        {
            foreach (var currency in currencies)
            {
                comboBoxFromCurrency.Items.Add($"{currency.Key} - {currency.Value}");
                comboBoxToCurrency.Items.Add($"{currency.Key} - {currency.Value}");
            }

            
            comboBoxFromCurrency.SelectedIndex = 0;

            
            int tryIndex = -1;
            for (int i = 0; i < comboBoxToCurrency.Items.Count; i++)
            {
                if (comboBoxToCurrency.Items[i].ToString().StartsWith("TRY"))
                {
                    tryIndex = i;
                    break;
                }
            }

            comboBoxToCurrency.SelectedIndex = tryIndex != -1 ? tryIndex : 1;
        }

        private async void buttonConvert_Click(object sender, EventArgs e)
        {
            await ConvertCurrency();
        }

        private async Task ConvertCurrency()
        {
            if (!decimal.TryParse(textBoxAmount.Text, out decimal amount))
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.", "Geçersiz Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fromCurrency = comboBoxFromCurrency.SelectedItem.ToString().Split('-')[0].Trim();
            string toCurrency = comboBoxToCurrency.SelectedItem.ToString().Split('-')[0].Trim();

            try
            {
                buttonConvert.Enabled = false;
                labelStatus.Text = "Döviz kurlarý alýnýyor...";
                decimal convertedAmount = await ConvertCurrencyAsync(amount, fromCurrency, toCurrency);
                textBoxResult.Text = $"{convertedAmount:N2} {toCurrency}";
                labelStatus.Text = $"Son güncelleme: {DateTime.Now}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Dönüþtürme Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelStatus.Text = "Döviz kurlarý alýnýrken hata oluþtu.";
            }
            finally
            {
                buttonConvert.Enabled = true;
            }
        }

        private async Task<decimal> ConvertCurrencyAsync(decimal amount, string fromCurrency, string toCurrency)
        {
            
            string url = $"{API_URL}{fromCurrency}";

            Debug.WriteLine($"Fetching rates from: {url}");

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            Debug.WriteLine($"API Response: {responseBody}");

            try
            {
                var exchangeRateData = JsonConvert.DeserializeObject<OpenExchangeRateResponse>(responseBody);

                if (exchangeRateData == null)
                {
                    throw new Exception("Döviz kuru verileri ayrýþtýrýlamadý.");
                }

                Debug.WriteLine($"Parsed data - Base: {exchangeRateData.Base}, Result: {exchangeRateData.Result}");

                if (exchangeRateData.Result != "success")
                {
                    throw new Exception("API baþarýsýz yanýt döndürdü.");
                }

                if (exchangeRateData.Rates == null || !exchangeRateData.Rates.ContainsKey(toCurrency))
                {
                    throw new Exception($"{toCurrency} için kur bulunamadý.");
                }

                decimal rate = exchangeRateData.Rates[toCurrency];
                Debug.WriteLine($"Rate found: {rate}");
                return amount * rate;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error processing API response: {ex.Message}");
                throw new Exception($"Döviz kuru verileri iþlenirken hata oluþtu: {ex.Message}");
            }
        }

        
        private void pictureBoxSwap_Click(object sender, EventArgs e)
        {
            int fromIndex = comboBoxFromCurrency.SelectedIndex;
            int toIndex = comboBoxToCurrency.SelectedIndex;

            comboBoxFromCurrency.SelectedIndex = toIndex;
            comboBoxToCurrency.SelectedIndex = fromIndex;

           
            if (!string.IsNullOrEmpty(textBoxAmount.Text) && decimal.TryParse(textBoxAmount.Text, out _))
            {
                _ = ConvertCurrency();
            }
        }
    }

    public class OpenExchangeRateResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("base_code")]
        public string Base { get; set; }

        [JsonProperty("rates")]
        public Dictionary<string, decimal> Rates { get; set; }

        [JsonProperty("time_last_update_utc")]
        public string UpdateTime { get; set; }
    }
}