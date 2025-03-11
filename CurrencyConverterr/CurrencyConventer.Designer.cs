namespace CurrencyConverter
{
    partial class CurrencyConverterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFrom = new Label();
            labelTo = new Label();
            comboBoxFromCurrency = new ComboBox();
            comboBoxToCurrency = new ComboBox();
            labelAmount = new Label();
            textBoxAmount = new TextBox();
            buttonConvert = new Button();
            labelResult = new Label();
            textBoxResult = new TextBox();
            labelStatus = new Label();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelBody = new Panel();
            pictureBoxSwap = new PictureBox();
            panelResult = new Panel();
            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSwap).BeginInit();
            panelResult.SuspendLayout();
            SuspendLayout();
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelFrom.ForeColor = Color.FromArgb(64, 64, 64);
            labelFrom.Location = new Point(23, 33);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(140, 23);
            labelFrom.TabIndex = 0;
            labelFrom.Text = "Çevirilecek Birim:";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelTo.ForeColor = Color.FromArgb(64, 64, 64);
            labelTo.Location = new Point(23, 127);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(120, 23);
            labelTo.TabIndex = 1;
            labelTo.Text = "Çevrilen Birim:";
            // 
            // comboBoxFromCurrency
            // 
            comboBoxFromCurrency.BackColor = Color.White;
            comboBoxFromCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFromCurrency.FlatStyle = FlatStyle.Flat;
            comboBoxFromCurrency.Font = new Font("Segoe UI", 11F);
            comboBoxFromCurrency.FormattingEnabled = true;
            comboBoxFromCurrency.Location = new Point(23, 63);
            comboBoxFromCurrency.Margin = new Padding(3, 4, 3, 4);
            comboBoxFromCurrency.Name = "comboBoxFromCurrency";
            comboBoxFromCurrency.Size = new Size(319, 33);
            comboBoxFromCurrency.TabIndex = 2;
            // 
            // comboBoxToCurrency
            // 
            comboBoxToCurrency.BackColor = Color.White;
            comboBoxToCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxToCurrency.FlatStyle = FlatStyle.Flat;
            comboBoxToCurrency.Font = new Font("Segoe UI", 11F);
            comboBoxToCurrency.FormattingEnabled = true;
            comboBoxToCurrency.Location = new Point(23, 156);
            comboBoxToCurrency.Margin = new Padding(3, 4, 3, 4);
            comboBoxToCurrency.Name = "comboBoxToCurrency";
            comboBoxToCurrency.Size = new Size(319, 33);
            comboBoxToCurrency.TabIndex = 3;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelAmount.ForeColor = Color.FromArgb(64, 64, 64);
            labelAmount.Location = new Point(23, 220);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(65, 23);
            labelAmount.TabIndex = 4;
            labelAmount.Text = "Miktar:";
            // 
            // textBoxAmount
            // 
            textBoxAmount.BorderStyle = BorderStyle.FixedSingle;
            textBoxAmount.Font = new Font("Segoe UI", 11F);
            textBoxAmount.Location = new Point(23, 249);
            textBoxAmount.Margin = new Padding(3, 4, 3, 4);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(320, 32);
            textBoxAmount.TabIndex = 5;
            // 
            // buttonConvert
            // 
            buttonConvert.BackColor = Color.FromArgb(0, 122, 204);
            buttonConvert.FlatAppearance.BorderSize = 0;
            buttonConvert.FlatStyle = FlatStyle.Flat;
            buttonConvert.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonConvert.ForeColor = Color.White;
            buttonConvert.Location = new Point(23, 307);
            buttonConvert.Margin = new Padding(3, 4, 3, 4);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(320, 53);
            buttonConvert.TabIndex = 6;
            buttonConvert.Text = "Çevir";
            buttonConvert.UseVisualStyleBackColor = false;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelResult.ForeColor = Color.FromArgb(64, 64, 64);
            labelResult.Location = new Point(17, 20);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(61, 23);
            labelResult.TabIndex = 7;
            labelResult.Text = "Sonuç:";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = Color.FromArgb(240, 240, 240);
            textBoxResult.BorderStyle = BorderStyle.None;
            textBoxResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            textBoxResult.ForeColor = Color.FromArgb(0, 122, 204);
            textBoxResult.Location = new Point(17, 49);
            textBoxResult.Margin = new Padding(3, 4, 3, 4);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(331, 32);
            textBoxResult.TabIndex = 8;
            textBoxResult.TextAlign = HorizontalAlignment.Center;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            labelStatus.ForeColor = Color.Gray;
            labelStatus.Location = new Point(17, 93);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(80, 19);
            labelStatus.TabIndex = 9;
            labelStatus.Text = "Bekleniyor..";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(366, 80);
            panelHeader.TabIndex = 10;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(23, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(192, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Döviz Çevirici";
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.White;
            panelBody.Controls.Add(pictureBoxSwap);
            panelBody.Controls.Add(labelFrom);
            panelBody.Controls.Add(comboBoxFromCurrency);
            panelBody.Controls.Add(labelTo);
            panelBody.Controls.Add(comboBoxToCurrency);
            panelBody.Controls.Add(labelAmount);
            panelBody.Controls.Add(textBoxAmount);
            panelBody.Controls.Add(buttonConvert);
            panelBody.Dock = DockStyle.Top;
            panelBody.Location = new Point(0, 80);
            panelBody.Margin = new Padding(3, 4, 3, 4);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(366, 387);
            panelBody.TabIndex = 11;
            // 
            // pictureBoxSwap
            // 
            pictureBoxSwap.Cursor = Cursors.Hand;
            pictureBoxSwap.Location = new Point(160, 108);
            pictureBoxSwap.Margin = new Padding(3, 4, 3, 4);
            pictureBoxSwap.Name = "pictureBoxSwap";
            pictureBoxSwap.Size = new Size(32, 32);
            pictureBoxSwap.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSwap.TabIndex = 7;
            pictureBoxSwap.TabStop = false;
            pictureBoxSwap.Click += pictureBoxSwap_Click;
            // 
            // panelResult
            // 
            panelResult.BackColor = Color.FromArgb(240, 240, 240);
            panelResult.Controls.Add(labelResult);
            panelResult.Controls.Add(textBoxResult);
            panelResult.Controls.Add(labelStatus);
            panelResult.Dock = DockStyle.Fill;
            panelResult.Location = new Point(0, 467);
            panelResult.Margin = new Padding(3, 4, 3, 4);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(366, 133);
            panelResult.TabIndex = 12;
            // 
            // CurrencyConverterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 600);
            Controls.Add(panelResult);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "CurrencyConverterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Döviz Çevirici Uygulaması";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSwap).EndInit();
            panelResult.ResumeLayout(false);
            panelResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboBoxFromCurrency;
        private System.Windows.Forms.ComboBox comboBoxToCurrency;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.PictureBox pictureBoxSwap;
    }
}