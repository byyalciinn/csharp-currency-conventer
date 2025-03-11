![Fotoğraf Açıklaması](https://hizliresim.com/tjlib8q)

# Döviz Çevirici

Gerçek zamanlı döviz kurlarını kullanarak farklı para birimleri arasında dönüşüm yapmanızı sağlayan basit bir C# Windows Forms uygulaması.

## Özellikler

- 10 ana para birimi arasında dönüşüm yapabilme
- exchangerate.host API'sinden alınan gerçek zamanlı döviz kurları
- Basit ve sezgisel kullanıcı arayüzü
- Para birimleri arasında hızlı geçiş yapabilme (Swap özelliği)

## Gereksinimler

- .NET 6.0 veya daha yüksek sürüm
- Windows işletim sistemi

## Nasıl Kullanılır

1. "From" açılır menüsünden kaynak para birimini seçin
2. "To" açılır menüsünden hedef para birimini seçin
3. Dönüştürmek istediğiniz miktarı girin
4. "Convert" düğmesine tıklayın
5. Dönüştürülen miktar "Result" alanında görüntülenecektir
6. Para birimleri arasında hızlı geçiş yapmak için ortadaki değiştirme (swap) simgesine tıklayabilirsiniz

## API Bilgisi

Bu uygulama, güncel döviz kurlarını almak için ücretsiz exchangerate.host API'sini kullanmaktadır. Temel kullanım için API anahtarı gerekmez.

## Kurulum Talimatları

1. Bu depoyu klonlayın veya indirin
2. Çözümü Visual Studio'da açın
3. Uygulamayı derleyin ve çalıştırın

## Not

Uygulama, API anahtarı gerektirmeyen ücretsiz exchangerate.host API'sini kullanacak şekilde ayarlanmıştır. Farklı bir API kullanmak isterseniz, `CurrencyConverter.cs` dosyasındaki `API_URL` değişkenini değiştirmeniz ve potansiyel olarak API anahtarınızı eklemeniz gerekecektir.

## Lisans

Bu proje açık kaynaklıdır ve MIT Lisansı altında kullanılabilir.
