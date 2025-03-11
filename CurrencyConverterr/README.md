# D�viz �evirici

Ger�ek zamanl� d�viz kurlar�n� kullanarak farkl� para birimleri aras�nda d�n���m yapman�z� sa�layan basit bir C# Windows Forms uygulamas�.

## �zellikler

- 10 ana para birimi aras�nda d�n���m yapabilme
- exchangerate.host API'sinden al�nan ger�ek zamanl� d�viz kurlar�
- Basit ve sezgisel kullan�c� aray�z�
- Para birimleri aras�nda h�zl� ge�i� yapabilme (Swap �zelli�i)

## Gereksinimler

- .NET 6.0 veya daha y�ksek s�r�m
- Windows i�letim sistemi

## Nas�l Kullan�l�r

1. "From" a��l�r men�s�nden kaynak para birimini se�in
2. "To" a��l�r men�s�nden hedef para birimini se�in
3. D�n��t�rmek istedi�iniz miktar� girin
4. "Convert" d��mesine t�klay�n
5. D�n��t�r�len miktar "Result" alan�nda g�r�nt�lenecektir
6. Para birimleri aras�nda h�zl� ge�i� yapmak i�in ortadaki de�i�tirme (swap) simgesine t�klayabilirsiniz

## API Bilgisi

Bu uygulama, g�ncel d�viz kurlar�n� almak i�in �cretsiz exchangerate.host API'sini kullanmaktad�r. Temel kullan�m i�in API anahtar� gerekmez.

## Kurulum Talimatlar�

1. Bu depoyu klonlay�n veya indirin
2. ��z�m� Visual Studio'da a��n
3. Uygulamay� derleyin ve �al��t�r�n

## Not

Uygulama, API anahtar� gerektirmeyen �cretsiz exchangerate.host API'sini kullanacak �ekilde ayarlanm��t�r. Farkl� bir API kullanmak isterseniz, `CurrencyConverter.cs` dosyas�ndaki `API_URL` de�i�kenini de�i�tirmeniz ve potansiyel olarak API anahtar�n�z� eklemeniz gerekecektir.

## Lisans

Bu proje a��k kaynakl�d�r ve MIT Lisans� alt�nda kullan�labilir.