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
            // Tek boyutlu dizi tanımı
            // Dizi elemanlarına değer atama
            // Dizi index numarası ile dizi öğelerine erişim  sağlanması
            // DeğişkenTürü[] DiziAdı = new DeğişkenTürü[ElemanSayısı]


            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]); // Beyaz

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]); // Üsküp
            //Console.WriteLine(cities[5]); // IndexOutOfRangeException dizin dizi sınırları dışında

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 145;
            //numbers[2] = 12;
            //numbers[3] = 3;
            //numbers[7] = 74;

            //Console.WriteLine(numbers[5]); // 0

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara" };
            //Console.WriteLine(cities[1]); // Roma

            #endregion

            #region Dizideki Tüm Elemanları Listeleme 

            // Dizi elemanlarını yazdırma
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe"};

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            // 3 ün katı olanları yazdırma
            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456 };
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            // Dizi elemanlarını yazdırma
            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            // Dizinin en büyük elemanını bulma
            //int[] myArray = {47,85,95,41,25,635,789,86,100};

            //int maxNumber= myArray[0];
            //for (int i = 0; i < myArray.Length; i++) 
            //{
            //    if (myArray[i] > maxNumber)
            //        maxNumber = myArray[i];
            //}
            //Console.WriteLine(maxNumber);

            // Dizinin uzunluğunu bulma
            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem","deniz" };
            //Console.WriteLine(persons.Length); // 6

            // Diziyi küçükten büyüğe sıralı yazdırma
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // Diziyi büyükten küçüğe tersten yazdırma
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotları 

            //string[] customers = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //int index = Array.IndexOf(customers, "ayşe");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35};
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + "\nDizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Dizi Elemanlarına Değer Alma 

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehrini giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("____________________");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            #endregion

            #region Dizide Toplama İşlemi 
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Dizide Tek-Çift Sayıları Bulma

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) 
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("_____________________");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            #endregion

            Console.Read();
        }
    }
}
