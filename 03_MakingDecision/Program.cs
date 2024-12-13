using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifrenizi girin: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");

            //}

            //else
            //{
            //    Console.WriteLine("Şifre yanlış");

            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}

            //else
            //{
            //    Console.Write("hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}

            //else
            //{
            //     Console.WriteLine("sayı hatalı");
            //}


            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama: " + average);

            //if (average >= 0 & average < 50)
            //{
            //    result = "Sonuç: Vasat";
            //}
            //if (average >= 50 & average < 70)
            //{
            //    result = "Sonuç: Orta";
            //}
            //if (average >= 70 & average < 85)
            //{
            //    result = "Sonuç: İyi";
            //}
            //if (average >= 85 & average <=100)
            //{
            //    result = "Sonuç: Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "bilecik")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();

            //if (username!= "admin")
            //{
            //    Console.WriteLine("kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}

            #endregion If Else

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());


            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");

            #endregion Mod İşlemleri

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Takımınızın sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' |  team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if(team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion Char Değişkenler ile Karar Yapıları

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ali Nazik");
            //    Console.WriteLine("2-Izgara Köfte");
            //    Console.WriteLine("3-Patlıcan Kebabı");
            //    Console.WriteLine("4-İskender");
            //    Console.WriteLine("5-Tavuk Şiş");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margaritha");
            //    Console.WriteLine("2-Akdeniz Pizza");
            //    Console.WriteLine("3-Karışık Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Trileçe");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //}


            #endregion Örnek Proje Uygulaması

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi");break;
            //}

            #endregion Switch Case

            #region Switch Case - Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.Write("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.Write("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.Write("Çarpım: " + result);
            //        break;


            //    case '/':
            //        result = number1 + number2;
            //        Console.Write("Toplam: " + result);
            //        break;
            //}

            #endregion Switch Case - Hesap Makinesi

            Console.Read();


        }
            
        }
    }
