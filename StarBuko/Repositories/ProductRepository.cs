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
                            });
                        }
                    }
                }
            }
            return products; 
        }

        public string AddProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO products (productName, price, image) VALUES (@productName, @price, @image)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productName", product.Name);
                    //cmd.Parameters.AddWithValue("@description", product.Description);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@image", product.ImagePath);
                    
                    int result = cmd.ExecuteNonQuery(); // Executes the query

                    if (result > 0)
                        return "Product added successfully.";
                    else
                        return "Failed to add product.";
                }
            }
        }
    }
}
