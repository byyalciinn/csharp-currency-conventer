# Döviz Çevirici

Gerçek zamanlý döviz kurlarýný kullanarak farklý para birimleri arasýnda dönüþüm yapmanýzý saðlayan basit bir C# Windows Forms uygulamasý.

## Özellikler

- 10 ana para birimi arasýnda dönüþüm yapabilme
- exchangerate.host API'sinden alýnan gerçek zamanlý döviz kurlarý
- Basit ve sezgisel kullanýcý arayüzü
- Para birimleri arasýnda hýzlý geçiþ yapabilme (Swap özelliði)

## Gereksinimler

- .NET 6.0 veya daha yüksek sürüm
- Windows iþletim sistemi

## Nasýl Kullanýlýr

1. "From" açýlýr menüsünden kaynak para birimini seçin
2. "To" açýlýr menüsünden hedef para birimini seçin
3. Dönüþtürmek istediðiniz miktarý girin
4. "Convert" düðmesine týklayýn
5. Dönüþtürülen miktar "Result" alanýnda görüntülenecektir
6. Para birimleri arasýnda hýzlý geçiþ yapmak için ortadaki deðiþtirme (swap) simgesine týklayabilirsiniz

## API Bilgisi

Bu uygulama, güncel döviz kurlarýný almak için ücretsiz exchangerate.host API'sini kullanmaktadýr. Temel kullaným için API anahtarý gerekmez.

## Kurulum Talimatlarý

1. Bu depoyu klonlayýn veya indirin
2. Çözümü Visual Studio'da açýn
3. Uygulamayý derleyin ve çalýþtýrýn

## Not

Uygulama, API anahtarý gerektirmeyen ücretsiz exchangerate.host API'sini kullanacak þekilde ayarlanmýþtýr. Farklý bir API kullanmak isterseniz, `CurrencyConverter.cs` dosyasýndaki `API_URL` deðiþkenini deðiþtirmeniz ve potansiyel olarak API anahtarýnýzý eklemeniz gerekecektir.

## Lisans

Bu proje açýk kaynaklýdýr ve MIT Lisansý altýnda kullanýlabilir.