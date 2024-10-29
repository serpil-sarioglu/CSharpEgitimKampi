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
            //1:Değişken türü
            //2:Değişken adı
            //3:in
            //4:Liste,Koleksiyon,Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 635, 41, 90, 32, 55, 678, 1235 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 635, 41, 90, 32, 55, 678, 1235 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 635, 41, 90, 32, 55, 678, 1235 };
            //int total = 0;

            //foreach (var i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>() { 1,2,3,4,5,6 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char item in word)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması 
            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Kullanıcıdan sınıftaki öğrenci sayısını alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrenci ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu girişi yapılır
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // 3 sınav notunun toplamını tutar
                }
                Console.WriteLine();
                                
                studentExamAvg[i] = totalExamResult / 3;
            }

            // Sınıfın sınav not ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması:  {studentExamAvg[i]}");

                // Dersi Geçti/Kaldı bulunması
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("------------------------------");
            }
            #endregion
            Console.Read();
        }
    }
}
