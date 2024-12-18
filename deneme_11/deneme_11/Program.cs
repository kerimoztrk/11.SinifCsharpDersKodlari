using System;
using System.Diagnostics.CodeAnalysis;

namespace deneme_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            /*
            Console.Write("Kerim");

            Console.WriteLine("ishak");
            Console.Write("ömer");
            */
            /*
            Console.WriteLine("---------- Yemek çeşitleri ----------");
            Console.WriteLine();
            Console.WriteLine("1- Ana Yemek");
            Console.WriteLine("2- Çorbalar");
            Console.WriteLine("3- Tatlılar");
            Console.WriteLine("4- Salatalar");
            Console.WriteLine("5- Tatlılar");
            Console.WriteLine("6- İçeçekler");
            Console.WriteLine();
            Console.WriteLine("---------- Yemek Çeşitleri ----------");

            */


            #endregion

            #region Değişken İsimlendirme Şekilleri

            // Snake Case =>  degisken_turu_ornegi
            // Camel Case =>  degiskenTuruOrnegi
            // Pascal Case => DegiskenTuruOrnegi
            // Hungarian Case => strDegiskenTuruOrnegi
            // Kebab Case =>   degisken-turu-ornegi


            #endregion

            #region String Değişkenler

            ////String

            //// degiskenTürü degiskenAdi;


            ////String name;
            ////name = "İwhak";
            ////Console.WriteLine(name);


            ////String customerName;
            ////String customerSurname;
            ////String customerEmail;
            ////String customerPhone, district, city;

            ////customerName = "Melih";
            ////customerSurname = "Acar";
            ////customerEmail = "deneme@hotmail.com";
            ////customerPhone = "05234234235";
            ////district = "gaziosmanpaşa";
            ////city = "istanbul";

            ////Console.WriteLine("----------Rezervasyon Kartı----------");
            ////Console.WriteLine();
            ////Console.WriteLine("Müşteri Adı: "+customerName);
            ////Console.WriteLine("Müşteri Soyadı: "+customerSurname);
            ////Console.WriteLine("Müşteri E-postası: "+customerEmail);
            ////Console.WriteLine("Müşteri Telefon Numarası: "+customerPhone);
            ////Console.WriteLine("Adres: "+city+"/"+district);
            ////Console.WriteLine();
            ////Console.WriteLine("----------Rezervasyon Kartı----------");


            ////customerName = "Kerim";
            ////customerSurname = "Öztürk";
            ////customerEmail = "deneme5252@hotmail.com";
            ////customerPhone=("1232145667");
            ////district = "Esenler";
            ////city = "İstanbul";


            ////Console.WriteLine("----------Rezervasyon Kartı-----------");
            ////Console.WriteLine();
            ////Console.WriteLine("Müşteri Adı: " + customerName);
            ////Console.WriteLine("Müşteri Soyadı: " + customerSurname);
            ////Console.WriteLine("Müşteri Epostası: " + customerEmail);
            ////Console.WriteLine("Müşteri Telefon Numarası: " + customerPhone);
            ////Console.WriteLine("Adres:" + district + "/" + city);
            ////Console.WriteLine();
            ////Console.WriteLine("-----------Rezervasyon Kartı--------------");

            #endregion

            #region İnt Değişkenler

            //int number;
            //number = 6;
            //int number2 = 5;
            //Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 45;
            //int waterPrice = 10;
            //int friesPrice = 100;
            //int lemonadePrice = 30;

            ////Console.WriteLine("*************** Restoran Menü Fiyatı ***************");
            ////Console.WriteLine();
            ////Console.WriteLine("Hamburger Fiyatı : "+ hamburgerPrice + "  TL");
            ////Console.WriteLine("Kola Fiyatı : " + cokePrice + "  TL");
            ////Console.WriteLine("Su Fiyatı : " + waterPrice + "  TL");
            ////Console.WriteLine("Kızartma Fiyatı : " + friesPrice + "  TL");
            ////Console.WriteLine("Limonata Fiyatı : " + lemonadePrice + "  TL");
            ////Console.WriteLine();
            ////Console.WriteLine("*************** Restoran Menü Fiyatı ***************");

            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int lemonadeCount;

            //int totalHamburgerPrice;
            //int totalCokePrice;
            //int totalWaterPrice;
            //int totalFriesPrice;
            //int totalLemonadePrice;

            //hamburgerCount = 2;
            //cokeCount = 1;
            //waterCount = 1;
            //friesCount = 1;
            //lemonadeCount = 1;

            //totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            //totalCokePrice = cokePrice * cokeCount;
            //totalWaterPrice = waterPrice * waterCount;
            //totalFriesPrice = friesPrice * friesCount;
            //totalLemonadePrice = lemonadePrice * lemonadeCount;

            //int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalLemonadePrice;

            //Console.WriteLine("**************** Sipariş Özeti ***************");
            //Console.WriteLine();
            //Console.WriteLine("Sizin Aldığınız Hamburger Fiyatı : " + totalHamburgerPrice + "  TL");
            //Console.WriteLine("Sizin Aldığınız Kola Fiyatı : " + totalCokePrice + "  TL");
            //Console.WriteLine("Sizin Aldığınız Kızartma Fiyatı : " + totalFriesPrice + "  TL");
            //Console.WriteLine("Sizin Aldığınız Su Fiyatı : " + totalWaterPrice + "  TL");
            //Console.WriteLine("Sizin Aldığınız Limonata Fiyatı : " + totalLemonadePrice + "  TL");
            //Console.WriteLine();


            //Console.WriteLine("Sipariş Toplam Ücreti : "+ totalPrice);
            //Console.WriteLine();

            //Console.WriteLine("**************** Sipariş Özeti ***************");




            #endregion

            #region Double Değişkenler
            //double number;
            //number = 0.52351;

            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 12.5;
            //orangePrice = 15.99;
            //strawberryPrice = 29.86;
            //patatoPrice = 59.99;
            //tomatoPrice = 26.75;


            //Console.WriteLine("---------- Fiyat Listesi ----------");
            //Console.WriteLine();
            //Console.WriteLine("----- Elma Kilogram Fiyatı : " + applePrice + "  TL");
            //Console.WriteLine("----- Portakal Kilogram Fiyatı : " + orangePrice + "  TL");
            //Console.WriteLine("----- Domates Kilogram Fiyatı : " + tomatoPrice + "  TL");
            //Console.WriteLine("----- Çilek Kilogram Fiyatı : " + strawberryPrice + "  TL");
            //Console.WriteLine("----- Patates Kilogram Fiyatı : " + patatoPrice + "  TL");
            //Console.WriteLine();
            //Console.WriteLine("---------- Fiyat Listesi ----------");

            //int yas = 12;
            //double yas2 = 156.12;
            //float deger = 12.1f;
            //char karakter= 'E';

            //string yas3 = "55.46 bu bir string değerdir";








            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("******* 11 - A Hava yolları Yolcu Bilgisi ******");
            //Console.WriteLine();

            //String PassengerName, passengerSurname, passengerDistrict, passengerCity, passengerIdentityNumber, passengerAge;


            //Console.Write("Yolcu adı: ");
            //PassengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş:");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC kimkik no: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------");

            //Console.WriteLine("Yolcu TC kimlik no : " + passengerIdentityNumber + "\nYolcu Ad Soyad: " + PassengerName + " " + passengerSurname + "\nİlçe Bilgisi: " + passengerDistrict + "\nŞehir Bilgisi: " + passengerCity + "\nYolcunun Yaşı: " + passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, tvPrice, chairPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 10000;

            //int shoesCount, computerCount, tvCount, chairCount;

            //Console.Write("Lütfen aldıgınız ayakkabı sayısını girniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon fiyatını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoesCount * shoesPrice) + (chairPrice * chairCount) + (computerCount * computerPrice) + (tvCount * tvPrice);

            //Console.WriteLine();
            //Console.WriteLine("TOplam ödemeniz gerekn tutar : " + totalPrice + " TL");







            #endregion


            #region Klavyeden Ondalıklı Sayu işlemleri

            //double exam1, exam2, exam3, result;


            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());


            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Öğrencimim Sınav ortalaması :  " + result);


            #endregion

            #region Klavyeden karakter Girişleri

            //char cinsiyet;

            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //cinsiyet = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + cinsiyet);



            #endregion

            #region Koşullu ifadeler ( İf / Else )

            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string sifre;
            //sifre = Console.ReadLine();

            //if (sifre == "abcd" || sifre=="ABCD")
            //{
            //    Console.WriteLine("Girilen şifre doğrudur.Sisteme giriş yapılıyor.");


            //}
            //else
            //{
            //    Console.WriteLine("Girilen şifre hatalı !");
            //}


            //string baskent, ulke;
            //Console.WriteLine("Başkenti giriniz:");
            //baskent = Console.ReadLine();
            //Console.WriteLine("Ülke giriniz: ");
            //ulke = Console.ReadLine();


            //if (baskent=="Ankara" & ulke == "Türkiye")
            //{
            //    Console.WriteLine("veriler doğru");
            //}
            //else
            //{
            //    Console.WriteLine("veriler yanlıştır.");
            //}


            //int sayi;
            //Console.WriteLine("Bir sayı giriniz: ");
            //sayi = int.Parse(Console.ReadLine());

            //if ( sayi == 4)
            //{
            //    Console.WriteLine("sayı doğru tahmin edildi.");

            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış tahmin edildi.");
            //}

            //double sinav1, sinav2, sinav3, ortalama;
            //string sonuc = "";

            //Console.WriteLine("1.Sınav Notunu gir: ");
            //sinav1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("2.Sınav Notunu gir: ");
            //sinav2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("3.Sınav notunu giriniz: ");
            //sinav3 = double.Parse(Console.ReadLine());

            //ortalama = (sinav1 + sinav2 + sinav3) / 3;
            //Console.WriteLine("Sınavların ortamalaı = " + ortalama);


            //if(ortalama>0 & ortalama < 50)
            //{
            //    sonuc = "Sonuç Rezalet";
            //}
            //if(ortalama>50 & ortalama < 70)
            //{
            //    sonuc = "Sonuç ortalama";
            //}
            //if (ortalama > 70 & ortalama <= 84)
            //{
            //    sonuc = " Sonuc iyi";

            //}
            //if (ortalama > 84)
            //{
            //    sonuc = "Sonuc mükkemmel";
            //}

            //Console.WriteLine(sonuc);

            //string sehir;
            //Console.WriteLine("Lütfen şehir girişi yapınız:");

            //sehir = Console.ReadLine();

            //if (sehir == "Trabzon" || sehir == "Ordu" || sehir == "giresun" || sehir == "samsun")
            //{
            //    Console.WriteLine("Girilen sehir karadeniz bölgesindedir.");

            //}

            //else
            //{
            //    Console.WriteLine("girilen şehir karadeniz bölgesinde mevcut değildir.");
            //}

            //Console.WriteLine("Lütfen Kullanıcı adı giriniz:");
            //string kullaniciadi = Console.ReadLine();

            //if (kullaniciadi != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez");

            //}
            //else
            //{
            //    Console.Write("Hoş geldniz");
            //}



            #endregion

            #region char değişkenler ile karar yapıları

            //char takım;
            //Console.WriteLine("Takım sembolü giriniz:");
            //takım = char.Parse(Console.ReadLine());

            //if(takım=='g' || takım == 'G')
            //{
            //    Console.WriteLine("GALATASARAY");
            //}
            //if(takım=='f' || takım== 'F')
            //{
            //    Console.WriteLine("FENERBAHÇE");

            //}
            //if (takım == 'b' || takım == 'B')
            //{
            //    Console.WriteLine("BEŞİKTAŞ");
            //}



            #endregion

            #region İf else Örnek Uygulama

            //Console.WriteLine(" 11- A  Eğitim Restoranı");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("1- Ana Yemek ");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine();

            //Console.WriteLine("Lütfen Detayını Görmek İstedğiniz Menünün Numarasını Giriniz: ");
            //string menuSecim = Console.ReadLine();

            //if (menuSecim == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Tavuk Pilav");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Ana Yemek -------------");
            //}

            //if(menuSecim == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Tarhana Çorbası");
            //    Console.WriteLine("3- Kelle Paça Çorbası");
            //    Console.WriteLine("4- Mantar Çorbası");
            //    Console.WriteLine("5- Domates Çorbası");
            //    Console.WriteLine();

            //}

            //if (menuSecim == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar -------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kuşbaşılı Pizzaa");
            //    Console.WriteLine("2- Bol Malzemos Pizza");
            //    Console.WriteLine("3- Margaritha Prizza");
            //    Console.WriteLine("4- Mantarlı Pizza");
            //    Console.WriteLine("5- Dört Peynirli Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("--------- Pizzalar --------");
            //}

            //if (menuSecim == "4")
            //{

            //    Console.WriteLine("--------- içeçekler ----");
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Meyve suyu");
            //    Console.WriteLine("3- Ayran");
            //    Console.WriteLine();
            //    Console.WriteLine("----------- İçecekler -------");

            //}
            //if (menuSecim == "5")
            //{

            //    Console.WriteLine("--------- Tatlılar ----");
            //    Console.WriteLine("1- Baklava");
            //    Console.WriteLine("2- Tiramisu");
            //    Console.WriteLine("3- Ekler");
            //    Console.WriteLine("4- künefe");
            //    Console.WriteLine();
            //    Console.WriteLine("----------- Tatlılar -------");

            //}



            // örnek 2 
            // klavyeden iki ürünün fiyatını girildiğnde toplam
            // fiyat 200 Tl den fazla ise 2. üründen
            // %25 indirim yaparak ödenecek tutarı
            // gösteren uygulama


            //double urun1, urun2, toplam, odencektutar, indirim;

            //Console.WriteLine("1. ürünün fiyatını girin: ");
            //  urun1=double.Parse(Console.ReadLine());
            //Console.WriteLine("2. ürünün fiyatını girin:");
            //urun2= double.Parse(Console.ReadLine());

            //toplam = urun1 + urun2;
            //odencektutar = toplam;

            //if (toplam >= 200)
            //{
            //    indirim = urun2 * 25 / 100;
            //    odencektutar = odencektutar - indirim;
            //}
            //Console.WriteLine("Odemeniz geren ücret =" + odencektutar + "  TL");


            #endregion


            #region Switch case

            //Console.Write("Yılın kaçıncı ayında oludugunu giriniz:");
            //int kacinciAy = int.Parse(Console.ReadLine());

            //switch (kacinciAy)
            //{
            //    case 1: Console.Write("Ocak");
            //        break;
            //    case 2: Console.Write("şubat");
            //        break;
            //    case 3: Console.Write("MArt");
            //        break;
            //    case 4: Console.Write("Nisan");
            //        break;
            //    case 5: Console.Write("Mayıs");
            //        break;
            //    case 6: Console.Write("Haziran");
            //        break;
            //    case 7: Console.Write("temmuz");
            //        break;
            //    case 8: Console.Write("Ağustos");
            //        break;
            //    case 9: Console.WriteLine("Eylül");
            //        break;
            //    case 10: Console.WriteLine("Ekim");
            //        break;
            //    case 11: Console.WriteLine("Kasım");
            //        break;
            //    case 12: Console.WriteLine("Aralık");
            //            break;
            //       default : Console.WriteLine("hatalı giriş");
            //        break;

            //}

            //int ay = DateTime.Now.Month;

            //switch (ay)
            //{


            //    case 12: Console.WriteLine("aralık0");
            //        break;
            //    case 1:
            //        Console.WriteLine("ocak");
            //        break;
            //}

            //switch (ay)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("kış ayındasın");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("ilkbahar ayındasın");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("yaz ayındasın");

            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("sonabahar ayındasın");
            //        break;
            //}

            #endregion


            #region Switch Case Hesap makinesi örneği

            //int sayi1, sayi2, sonuc;

            //char sembol;

            //Console.WriteLine("1. sayıyı giriniz: ");
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. sayıyı giriniz: ");
            //sayi2= int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen yapmak istedğiniz işlemi giriniz:");
            // sembol = char.Parse(Console.ReadLine());


            //switch (sembol)
            //{


            //    case '+':
            //        sonuc = sayi1 + sayi2;
            //        Console.WriteLine("Toplama işleminin sonucu : " + sonuc);
            //        break;
            //    case '-':
            //        sonuc = sayi1 - sayi2;
            //        Console.WriteLine(":Çıkarma işleminin sonucu : " + sonuc);
            //        break;
            //    case '/':
            //        sonuc = sayi1 / sayi2;
            //        Console.WriteLine("Bölme işleminin sonucu : " + sonuc);
            //        break;
            //    case '*':
            //        sonuc = sayi1 * sayi2;
            //        Console.WriteLine("Çarpma işleminin sonucu : " + sonuc);
            //        break;

            //    case '%':
            //        sonuc = sayi1 % sayi2;
            //        Console.WriteLine(" Mod işlemnin sonucu : " + sonuc);
            //         break;

            //    default:
            //        Console.WriteLine("Hatalı operatör seçtiniz");
            //        break;


            //}



            #endregion

            #region Switch case Restoran Uygulaması

            //Console.WriteLine("Akşam yemeği mi yoksa Kahvaltı mı ?");
            //string cevap = Console.ReadLine();
            //Console.WriteLine("Kaç kişi ?");
            //int kisi = int.Parse(Console.ReadLine());
            //string fiyat = " ";

            //switch (cevap)
            //{
            //    case "AKŞAM YEMEĞİ" when kisi == 1:
            //        fiyat = "100";
            //        break;

            //    case "AKŞAM YEMEĞİ" when kisi == 2:
            //        fiyat = "200";
            //        break;

            //    case "KAHVALTI" when kisi == 1:
            //        fiyat = "180";
            //        break;

            //    case "KAHVALTI" when kisi == 2:
            //        fiyat = "360";
            //        break;
            //}

            //Console.WriteLine(" Ödenecek tutar : " + fiyat);



            #endregion

            #region for döngüsü


            // for(x;y;z)

            //x = başlanıc
            //y = bitiş
            // z = artoş azalış


            //for(int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("11 A sınıfı");

            //}

            //for (int i=5; i>=1 ; i--)
            //{
            //    Console.WriteLine(i+") 11 A sınıfı nefatif ");

            //}

            //int i;

            //for( i=1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (i = 20; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //for(int i =3; i<=51; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region For Döngüsü ile karar yapıları

            //for (int i=1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int toplam = 0;
            //// yapılan işlem 1+2+3+4+5+6+7+8+9+10
            //for(int i = 1; i <= 10; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);


            //int toplam = 0;
            ////20 ye kadar olan kısımda 2nin katlarını topluyor ve ekrana yazıyor.
            //for(int i=1; i <= 20; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine(toplam );

            //int sayac = 0;

            //for (int i = 0; i < 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        sayac++;

            //    }
            //}
            //Console.WriteLine(sayac);


            //1-2-4-8-16 bakteri üreme
            //int bakteri = 1;
            //for(int i =1 ; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + ". Saat sonunda: " + bakteri);
            //}


            //int bakteri = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    int dakika = i * 60;
            //    Console.WriteLine(dakika + ". Dakika sonunda: " + bakteri);
            //}

            //int bakteri = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //   int saniye = i * 60 * 60;
            //    Console.WriteLine(saniye + ". saniye sonunda: " + bakteri);
            //}








            #endregion

            #region while Döngüsü

            //while (şart)
            //{
            //    işlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Dünya");

            //    i++;
            //}

            //int i = 1;
            // while (i <= 10)
            // {
            //     if (i % 3 == 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            //     i++;
            // }


            //int i = 1;
            //int toplam = 0;

            //while (i <= 10)
            //{
            //    toplam += i;
            //        i++;
            //}

            //Console.WriteLine(toplam);

            #endregion


            #region Örnek Sınav Sorusu

            //Klavyeden giriln 3 basamaklı
            //sayınınbasamakrı toplmanı hesaplayan
            //kdou yazınız.

            //456

            Console.WriteLine("Sayıyı giriniz:");
            int sayi =int.Parse(Console.ReadLine());
            int birler, onlar, yuzler;
            int toplam;

                birler = sayi % 10;
            onlar = (sayi % 100) / 10;
            yuzler = sayi / 100;   //4.56 ---> 4 kısmını alıyor.

            Console.WriteLine(birler + "-" + onlar + "-" + yuzler);

            toplam = birler + onlar + yuzler;

            Console.WriteLine(toplam);

            #endregion










            Console.ReadLine();
        }
    }
}
