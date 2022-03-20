using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumTestTool
{
    class Program
    {
        static void Main(string[] args)
        {//Web tabanlı sistemlerde testleri yapmak için geliştirilmiş bir test aracıdır veya kütüphanedir.

            IWebDriver driver = new FirefoxDriver();//Hangi tarayıcı üzerinden işlem yapacağımı belirtiyorum.
            string link = @"https://www.n11.com/";
            driver.Navigate().GoToUrl(link);//Url'e gitme işlemi



            {//Login Test Aşaması
                //Giriş yap butonunun class=btnSignIn bilgisi
                driver.FindElement(By.ClassName("btnSignIn")).Click(); // Butonu clickleyip o sayfaya gidecek

                //Email textbox'ın id=email bilgisi
                driver.FindElement(By.Id("email")).SendKeys("alisarideneme@outlook.com");// SendKesys() komudu ile değer gönderilecek

                //Şifre textbox'ın id=password bilgisi
                driver.FindElement(By.Id("password")).SendKeys("258963ali");// SendKesys() komudu ile değer gönderilecek

                // Üye girişi yapmak için butonun id=loginButton bilgisi
                driver.FindElement(By.Id("loginButton")).Click();// Id bilgisi varsa onu kullanalım class bilgisi birden çok yerde kullanılabiliniyor.
            }

            Thread.Sleep(2000);

            // Arama textbox'ın      id=searchData   bilgisi
            driver.FindElement(By.Id("searchData")).SendKeys("Samsung"); // Samsung verilerini arıyorum

            // Arama Butonun      class=searchBtn  bilgisi
            driver.FindElement(By.ClassName("searchBtn")).Click();


            // Normalde sadece class bilgisi varsa onu verebilirim fakat bazen sayfalarımızda class veya id bilgisi verilmeye bilir o yüzden adım adım bakıyorum. Alt div'e nasıl geçilir
            // 2. sayfaya geçmek için öncelikle tüm sayfanın olduğu div lazım   id=contentListing    bilgisi 
            // Sonrasında altında bir div var o divin içersine giriyoruz
            // Tekrar bakıyoruz kaç div var tek div olduğu için 
            // İçinde 2 farklı div var biz sağdaki divi alıcaz. Birden fazla olduğu için [2] dizi şeklinde hangisi ise seçmeliyiz şeklinde devam ederiz

            // Veya bu adımları yapmak yerine  direk istediğimiz mesela ikinci sayfa butonunu inceleyerek Copy XPath yapabliriz
            // fakat "contentListing" yerine 'contentListing' yazılması gerekir yani tek tırnak

            // SAYFA NUMARASI 2 OLAN BUTON'UN XPATH'I LAZIM
            //*[@id="contentListing"]/div/div/div[2]/div[4]/a[2]
            //                          bütün sayfa içersinde id=contentListing bul altındaki div'e gir
            driver.FindElement(By.XPath("//*[@id='contentListing']/div/div/div[2]/div[4]/a[2]")).Click(); // XPath bütün sayfa içinde arama yapan bir cümlecik


            // Rasgele bir ürün seçiyorum o ürüne ait en baştaki div için id=p-530088692 bilgisi a link bilgisinin XPath olarak kopyalarsam unutmayayım Tek Tırnak ve arada boşluk yok visual kendi otomatik atıyor düzelt
            driver.FindElement(By.XPath("//*[@id='p-489569060']/div[1]/a")).Click();
           
            Thread.Sleep(4000);//Bekleme süresi koyuyyorum sayfa yüklensin yoksa patlıyor


            // Detayları görmek için class=detailPreviewBtn
            driver.FindElement(By.ClassName("detailPreviewBtn")).Click();

            Thread.Sleep(1000);

            // Detayları kapatmak için class=btnOk
            driver.FindElement(By.ClassName("btnOk")).Click();

            Thread.Sleep(2000);

            // Adetini 1 tane arttırmak için buton bilgisi XPath hali
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[1]/div[1]/div[2]/form/div[2]/div[2]/div[1]/div/div/span[1]")).Click();

            // Sepete eklemek için buton bilgisi class=addBasketUnify
            driver.FindElement(By.ClassName("addBasketUnify")).Click();

            Thread.Sleep(1000);

            // Sepette adeti olmayan ürün hata mesajını kapatma XPath
            driver.FindElement(By.ClassName("confirm")).Click();

            Thread.Sleep(1000);

            // Sepete eklediğim ürün adetini azaltma class=spinnerDown 
            driver.FindElement(By.ClassName("spinnerDown")).Click();

            // Sepete eklemek için buton bilgisi class=addBasketUnify
            driver.FindElement(By.ClassName("addBasketUnify")).Click();

            Thread.Sleep(2000);

            // Sepete Gitmek için buton bilgisi class=btnGoBasket
            driver.FindElement(By.ClassName("btnGoBasket")).Click();


            // Karşıma çıkan Aydıtlatma Metnini kapatmak için XPath
            // Aydınlatma metni kullanıcı giriş yapmadıysa çıkar
            //driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/span")).Click();
        
            Thread.Sleep(2000);

            // Sepetteki Ürünü silmek için class=removeProd 
            driver.FindElement(By.ClassName("removeProd")).Click();

            Thread.Sleep(2000);

            // Anasayfaya Dönmek için class=home 
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/a")).Click();

            //Thread.Sleep(9000);

            // En son kullanıcı hesabımdan çıkış yapmak için class=logoutBtn
            //driver.FindElement(By.ClassName("logoutBtn")).Click();

        }
    }
}
