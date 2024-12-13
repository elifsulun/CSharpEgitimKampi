using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2.4.6.8
            //sarı, kırmızı, mavi, beyaz, turuncu
            //adana, ankara, istanbul, bursa
            //Değişken Türü [] DiziAdı = new Değişken Türü[Eleman sayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Beyaz";
            //colors[2] = "Sarı";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Paris";
            //cities[1] = "İskenderiye";
            //cities[2] = "İstanbul";
            //cities[3] = "Londra";
            //cities[4] = "Bilecik";

            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[7] = 58;
            //numbers[9] = 21;

            //Console.WriteLine(numbers[3]);

            //string[] cities = { "İstanbul", "Roma", "Paris", "Tokyo", "Viyana" };
            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "kahve", "füme", "antrasit", "siyah", "bej", "kiremit", "bordo" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 82, 98, 74, 9, 54, 72, 11, 67, 18, 35, 90, 765, 982, 448 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'A', 'B', 'C', '/', '^', 'x' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 54, 98, 0, 32, 19, 48, 39, 26, 993, 239, 237 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];                    
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ayşe", "veli", "fatma" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 2, 5, 9, 23, 465, 78, 12, 93, 67 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 2, 5, 9, 23, 465, 78, 12, 93, 67 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] customers = { "sema", "tuana", "özge", "semiha", "tuba", "binnur" };
            //int index = Array.IndexOf(customers, "özge");
            //Console.WriteLine(index);

            //int[] numbers = { 65, 92, 15, 53, 67, 92019, 234, 1, 446, 23, 68 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + ", Dizinin en küçük elemanı: " +  numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion

            Console.Read();
        }
    }
}
