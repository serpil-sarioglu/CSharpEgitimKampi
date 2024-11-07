using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("***** C# Veri Tabanlı Ürün- Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("---------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------");

            #region 1. yol Veri tabanında tablodan veri çekme 

            ////Veri tabanına bir bağlantı açılır
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-7A4VAITE;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            ////Sql sorgusu tanımlanır
            //SqlCommand command = new SqlCommand("Select * From TblCategory",connection);

            ////Sql komutunu çalıştırarak veriyi DataTable'a doldurur
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            ////Bağlantı kapatılır
            //connection.Close();

            //Veriler konsola yazdırılır
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString());
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 2. yol         
            string connectionString = ConfigurationManager.ConnectionStrings["_09_DatabaseProject.Properties.Settings.EgitimKampiDbConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM TblCategory";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Console.WriteLine(string.Join(", ", row.ItemArray));
                    }
                }
            }
            #endregion



            Console.Read();
        }
    }
}
#region Not | Örnek DataTable satırların sütunlarına ait değerlerine erişim
//DataTable dataTable = new DataTable();
//// DataTable'a sütunlar ekleyelim
//dataTable.Columns.Add("Ad", typeof(string));
//dataTable.Columns.Add("Soyad", typeof(string));

//// DataRow ekleyelim
//dataTable.Rows.Add("Ali", "Veli");
//dataTable.Rows.Add("Ayşe", "Yılmaz");

//// Satırlara erişim
//foreach (DataRow row in dataTable.Rows)
//{
//    string ad = row["Ad"].ToString();
//    string soyad = row["Soyad"].ToString();
//    Console.WriteLine($"Ad: {ad}, Soyad: {soyad}");
//}

/*-----------------------------------------------------------*/

//DataTable dataTable = new DataTable();
//dataTable.Columns.Add("Ad", typeof(string));
//dataTable.Columns.Add("Soyad", typeof(string));
//dataTable.Columns.Add("Yaş", typeof(int));

//// DataRow ekleyelim
//dataTable.Rows.Add("Ali", "Veli", 25);
//dataTable.Rows.Add("Ayşe", "Yılmaz", 30);

//// Satırlara erişim
//foreach (DataRow row in dataTable.Rows)
//{
//    // ItemArray kullanarak tüm sütun değerlerini alalım
//    object[] values = row.ItemArray;

//    foreach (var value in values)
//    {
//        Console.Write(value + " ");
//    }
//    Console.WriteLine();
//}

#endregion