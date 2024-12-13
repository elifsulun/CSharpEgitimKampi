using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //1: Değişken Türü
            //2: Değişken Adı
            //3: In
            //4: Liste, Koleksiyon, Dizi

            //string[] cities = { "Milano", "Roma", "Barselona", "Madrid", "Viyana" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 47, 22, 94, 810, 38, 345, 917, 6802, 1034, 2749, 65 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("-----------------------------------------------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------------------------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamScore = 0;

                //Her öğrenci için 3 sınav notu girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamScore += value; //notları topluyoruz
            //    }
            //    Console.WriteLine(); 

            //    studentExamAvg[i] = totalExamScore / 3;                               
            //}

            //Sınav ortalamaları

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("-----------------------------------------------------------------------");

            //    Console.WriteLine($"{studentNames[i]} isimli öğrencinin not ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin geçip kalma durumları

            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı.");
            //    }

            //    Console.WriteLine("-----------------------------------------------------------------------");

            //}

            #endregion

            Console.Read();
        }
    }
}
