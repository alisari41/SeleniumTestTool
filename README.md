
# Selenium ile N11 alışveriş sitesinde giriş yapma ve ürün ekleme, silme testleri 

## Selenium
![image](https://user-images.githubusercontent.com/81421228/159133429-387b09c6-1b53-42e5-b50f-8e3dfe92bb69.png)

Öncelikle Selenium nedir ve neden tercih edilir bununla başlayalım. Selenium, farklı tarayıcılarda ve platformlarda kullanılabilen, web uygulamaları için açık kaynaklı bir test paketidir. Selenium kullanarak masaüstü uygulamalar veya mobil uygulamalar test edilemez. Amaç web tabanlı uygulamaların testlerini otomatize etmektir.

Selenium RC, Selenium IDE, Selenium Grid, Selenium WebDriver olmak üzere farklı amaçlar için tasarlanmış dört araçtan oluşur. Selenium, sunduğu çeşitli avantajlar nedeniyle, test cihazları arasında çok popüler hale gelmiştir.

### Neden Selenium ?

![image](https://user-images.githubusercontent.com/81421228/159133477-6137997b-d1fb-4810-825c-2f6454270b77.png)

Aynı görevi yapan pek çok benzer araç var ancak Selenium daha çok tercih ediliyor.Peki Selenium’u bu kadar öne çıkaran ne?
- Selenium açık kaynaklı olduğundan, lisans maliyeti yoktur.
- Daha önce de belirtildiği gibi, Selenium’un bir takım araçları vardır, bu yüzden kullanıcıların her ihtiyacına uygundur. Farklı ihtiyaçlarınızı karşılamak için WebDriver, Grid ve IDE gibi çeşitli araçları kullanabilirsiniz.
- Bir test cihazının veya geliştiricinin bir otomasyon test aracıyla karşılaştığı en büyük zorluk, dil desteğidir.Test komut dosyaları herhangi bir programlama dilinde yazılabilir.(Örneğin Java, Python, .Net)
- Platform bağımsızdır, herhangi bir işletim sisteminde kullanılabilir.
- Testleri yaparken herhangi bir tarayıcı kullanılabilir.Bu kullanımı esnek hale getirir(Örneğin Mozilla Firefox, Google Chrome,Safari).
- Testleri yönetmek ve rapor üretmek için TestNG ve JUnit gibi araçlar ile entegre edilebilir.
- Sürekli test yapmak için Maven, Jenkins ve Docker entegre edilebilir. 

## Demo
- N11 sitesine gidiyor.
- n11 sitesinde giriş yapıyor
- Samsung ürünleri arıyor. 
- İkinci sayfadan herhangi bir ürün Xpath'ıni veriyorum. O ürüne gidiyor.
- Detay butonunu test ediliyor.
- Adet alanı test ediliyor.
- Sepete ekleme işlemleri test ediliyor.
- Sepete gidiliyor.
- Sepetteki ürün siliniyor.
- Anasayfaya dönme işlemi test ediliyor ve test bitiyor.


  ![TestTool_edit_0](https://user-images.githubusercontent.com/81421228/159164460-436611f8-e056-4cb8-9e31-4fb35f1154a2.gif)
