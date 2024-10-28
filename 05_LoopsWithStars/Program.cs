using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma 
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Yan yana 10 tane yıldız oluşturma 
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region Alt alta 10 satır yıldız ve her satırda 10 tane yıldız oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            #endregion

            #region Dik üçgen
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters dik üçgen
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Dik ve ters üçgen beraber (tabanları aynı simetrik iki üçgen)
            //int height = 5;
            //for (int i = 1; i <= height; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = height - 1; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Baklava Dilimi           
            //// Üst üçgen
            //int height = 5; 
            //for (int i = 1; i <= height; i++)
            //{
            //    // Boşlukları yazdır
            //    for (int j = height; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızları yazdır
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //// Alt üçgen
            //for (int i = height - 1; i >= 1; i--)
            //{
            //    // Boşlukları yazdır
            //    for (int j = height; j >= i; j--)
            //        Console.Write(" ");
            //    // Yıldızları yazdır
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            #endregion

            #region Piramit

            //int height = 5;
            //for (int i = 1; i <= height; i++)
            //{
            //    // Boşlukları yazdır
            //    for (int j = height - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızları yazdır
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Piramit

            int height = 5;
            for (int i = height; i >= 1; i--)
            {
                // Boşlukları yazdır
                for (int j = height - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                // Yıldızları yazdır
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
            Console.Read();
        }
    }
}
