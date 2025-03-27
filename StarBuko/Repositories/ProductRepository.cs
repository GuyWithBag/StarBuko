using StarBuko.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient; 
//using MySqlConnector;

namespace StarBuko.Repositories
{
    class ProductRepository
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString; 

        public List<Product> GetProducts()
        {
            var products = new List<Product>(); 
            //MessageBox.Show(_connectionString)
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                String query = "SELECT * FROM products";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                Name = reader.GetString("productName"),
                                Price = reader.GetDecimal("price"),
                                ImagePath = reader.GetString("image")
                            }); ;
                        }
                    }
                }
            }
            return products; 
        }

    }
}
