using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine("");

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat: " + applePrice + " TL - Gramaj: " + appleGram + " kg - Toplam Tutar: " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat: " + orangePrice + " TL - Gramaj: " + orangeGram + " kg - Toplam Tutar: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyat: " + strawberryPrice + " TL - Gramaj: " + strawberryGram + " kg - Toplam Tutar: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyat: " + potatoPrice + " TL - Gramaj: " + potatoGram + " kg - Toplam Tutar: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat: " + tomatoPrice + " TL - Gramaj: " + tomatoGram + " kg - Toplam Tutar: " + tomatoTotalPrice + " TL");

            //double shoppingPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingPrice + " TL");


            #endregion Double Değişkenler

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //''

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion Char Değişkenler

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Havayolları Yolcu Bilgisi");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC No: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Yolcu: " + passengerIdentityNumber + " - " + passengerName + " " + passengerSurname + " - " + passengerDistrict + "/" + passengerCity + " - " + passengerAge);


            #endregion Klavyeden Veri Girişleri String Değişkenler

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice;
            //totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Ödemeniz gereken toplam tutar: " + totalPrice + " TL");

            #endregion Klavyeden Tam Sayı Girişleri ve Dönüşümler

            #region Klavyeden Ondalıklı Sayı Girişleri ve Dönüşümler (Double)

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav sonucunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav sonucunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav sonucunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: " + result);

            #endregion Klavyeden Ondalıklı Sayı Girişleri ve Dönüşümler (Double)

            #region Klavyeden Karakter Girişleri (Char)

            //char gender;
            //Console.Write("Lütfen cinsiyetinizi seçin: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyet: " + gender);

            #endregion Klavyeden Karakter Girişleri (Char)


            Console.Read();


        }
    }
}
