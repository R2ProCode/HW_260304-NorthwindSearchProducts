using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HW_260304_NorthwindSearchProducts.Models
{
    public class NorthwindDbManager
    {
        private string _connectionString;

        public NorthwindDbManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Product> SearchProducts(int minStock, int maxStock)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Products WHERE UnitsInStock BETWEEN @MinStock AND @MaxStock";
            command.Parameters.AddWithValue("@MinStock", minStock);
            command.Parameters.AddWithValue("@MaxStock", maxStock); 

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while(reader.Read())
            {
                products.Add(new Product
                {
                    ProductId = (int)reader["ProductID"],
                    ProductName = (string)reader["ProductName"],
                    UnitPrice = (decimal)reader["UnitPrice"],
                    UnitsInStock = (short)reader["UnitsInStock"]
                });
            }

            return products;
        }
    }
}