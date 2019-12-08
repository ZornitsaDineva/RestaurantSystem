using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace RestaurantSystem
{
    class DBAccess
    {
        List<Product> GetProducts()
        {
            string connectionString = "Server=localhost; Initial Catalog=RestaurantSystem; Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sql = "SELECT [ID],[Name],[Price],[Qty],[LowStockThresheld] FROM[RestaurantSystem].[dbo].[Product]";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (dataReader.Read())
            {
                Product product = new Product();
                product.Id = dataReader.GetInt32(0);
                product.Name = dataReader.GetString(1);
                product.Price = dataReader.GetDecimal(2);
                product.Qty = dataReader.GetInt32(3);
                product.LowStockThresheld = dataReader.GetInt32(4);
                products.Add(product);
            }
            connection.Close();
            return products;
        }

        public Restaurant GetRestaurant()
        {
            Restaurant restaurant = new Restaurant();
            //List<Product> products = GetTestProducts();
            List<Product> products = GetProducts();
            restaurant.Products = products;
            return restaurant;
        }

        private static List<Product> GetTestProducts()
        {
            Product product = new Product
            {
                Name = "milk",
                Qty = 0,
                LowStockThresheld = 5
            };
            List<Product> products = new List<Product>();
            products.Add(product);
            return products;
        }
    }
}
