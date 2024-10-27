using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü 
            // for(x;y;z)
            // x:başlangıç  y:bitiş  z:artış/azalış

            // Beş kez 'C# Eğitim Kampı' yazdırır
            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            // 1 den 20 ye kadar ardışık sayıları yazdırır
            //for (i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 1 den 50 ye kadar 3'e tam bölünen ardışık sayıları yazdırır
            //for (i = 3;  i <= 50 ; i+=3)
            //{
            //    Console.WriteLine(i);                
            //}

            // Bitiş değerinin kullanıcıdan alındığı for döngüsünü yazalım 
            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++) 
            //{ 
            //    Console.WriteLine("Yaşasın Cumhuriyet!");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları 

            // 1 den 100 e kadar  5'e tam bölünen sayıları  if karar yapısını kullanarak for döngüsüyle yazdırır

            //for (int i = 1; i <= 100; i++) 
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // 1 den 10 a kadar sayıların toplamını for döngüsüyle yazdırır
            // (i değişkeni son değeri 11, totalValue değişkeni son değeri 55)

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            // 1 ile 20 arasındaki çift sayıları ve en son bu sayıların toplamını yazdırır

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("______");
            //Console.WriteLine(totalValue);

            // 1 ile 60 arasında 7'ye tam bölünen ardışık kaç tam sayı vardır yazdırır

            //int count = 0;
            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //        count++;
            //} 
            //Console.WriteLine(count);


            // Bir bakteri türü her 1 saatin sonunda kendini ikiye bölerek çoğaltmaktadır. Ortamda başlangıçta bir bakteri vardır. Yeni oluşan bakterilerde aynı şekilde çoğalıyorsa 24 saatin sonunda bu ortamda kaç tane bakteri olduğunu hesaplayan programın kodunu yazalım.
            // (Bakteri sayısı  1-2-4-8-16-...)

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++) 
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda: " + bacterium + " bakteri");

            //}

            #endregion

            #region While Döngüsü 

            //while(şart)
            //{ 
            //    işlemler 
            //}

            // Şart sağlandığı sürece While Döngüsü yazdırılır

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("While Döngüsü");
            //    i++;
            //}

            // 1 ile 10 arasında 3'e tam bölünen sayılar while döngüsü ile karar yapılarını kullanarak yazdırılır
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            // while döngüsü ile 1 den 10 a kadar sayıların toplamı yazdırılır
            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

             #region Örnek Sınav Sorusu

            // Klavyden girilen 3 basamaklı sayının basamak değerleri toplamını hesaplayan kodu yazınız

            //number = 456 
            //Console.Write("Üç basamaklı bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;         // 6
            //tens = (number % 100) / 10; // (56)/10 = 5,6 --> 5
            //hundreds = number / 100;    // 4,56 --> 4

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine("Basamak değerleri toplamı: " + sum);

            #endregion



            Console.Read();
        }
    }
}
