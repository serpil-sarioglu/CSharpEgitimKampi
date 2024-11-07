using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("--------------------------------------");
            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-7A4VAITE;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori başarıyla eklendi");
            #endregion

            #region Ürün Ekleme İşlemi 

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-7A4VAITE; Initial Catalog=EgitimKampiDB; Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName,@productPrice,@productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //Console.WriteLine("Ürün başarıyla eklendi");

            #endregion

            #region Ürün Listeleme İşlemi 

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-7A4VAITE;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    object[] values = row.ItemArray;
            //    foreach (var value in values)
            //    {
            //        Console.Write(value.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi 

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine()); 


            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-7A4VAITE;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId = @productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün başarıyla silindi");
            #endregion

            #region Ürün Güncelleme Eğitimi 
            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-7A4VAITE;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Ürün başarıyla güncellendi");
            #endregion

            Console.Read();
        }
    }
}
