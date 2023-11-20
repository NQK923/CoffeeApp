using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ProductDAL
    {
        private string connectionString = @"Data Source=DESKTOP-0HUV1DN\SQLEXPRESS;Initial Catalog=Coffee;User ID=sa;Password=123;TrustServerCertificate=true;";
        public List<ProductDTO> GetProducts()
        {
            List<ProductDTO> products = new List<ProductDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DrinkId, DrinkName, Price, Cost, Provider FROM Drink";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductDTO drink = new ProductDTO
                        {
                            DrinkId = reader.GetInt32(0),
                            DrinkName = reader.GetString(1),
                            Price = reader.GetDecimal(2),
                            Cost = reader.GetDecimal(3),
                            Provider = reader.GetString(4)
                        };

                        products.Add(drink);
                    }
                }
            }

            return products;
        }
        public void UpdateDrink(ProductDTO product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Drink SET DrinkName = @DrinkName, Price = @Price, Cost = @Cost, Provider = @Provider WHERE DrinkId = @DrinkId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@DrinkId", product.DrinkId);
                    command.Parameters.AddWithValue("@DrinkName", product.DrinkName);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Cost", product.Cost);
                    command.Parameters.AddWithValue("@Provider", product.Provider);

                    command.ExecuteNonQuery();
                }
            }
        }

        public ProductDTO GetProductByName(string productName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DrinkId, DrinkName, Price, Cost, Provider FROM Drink WHERE DrinkName = @DrinkName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrinkName", productName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ProductDTO product = new ProductDTO
                            {
                                DrinkId = reader.GetInt32(0),
                                DrinkName = reader.GetString(1),
                                Price = reader.GetDecimal(2),
                                Cost = reader.GetDecimal(3),
                                Provider = reader.GetString(4)
                            };

                            return product;
                        }
                    }
                }
            }

            return null;
        }
        public ProductDTO GetProductById(string productId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DrinkId, DrinkName, Price, Cost, Provider FROM Drink WHERE DrinkId = @DrinkId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrinkId", productId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ProductDTO product = new ProductDTO
                            {
                                DrinkId = reader.GetInt32(0),
                                DrinkName = reader.GetString(1),
                                Price = reader.GetDecimal(2),
                                Cost = reader.GetDecimal(3),
                                Provider = reader.GetString(4)
                            };

                            return product;
                        }
                    }
                }
            }

            return null;
        }
        public void UpdateProduct(ProductDTO product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Drink SET DrinkName = @DrinkName, Price = @Price, Cost = @Cost, Provider = @Provider WHERE DrinkId = @DrinkId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@DrinkId", product.DrinkId);
                    command.Parameters.AddWithValue("@DrinkName", product.DrinkName);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Cost", product.Cost);
                    command.Parameters.AddWithValue("@Provider", product.Provider);

                    command.ExecuteNonQuery();
                }
            }
        }

        public int GetDrinkID(String drinkName)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DrinkId FROM Drink WHERE DrinkName = @DrinkName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrinkName", drinkName);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int drinkId;
                        if (int.TryParse(result.ToString(), out drinkId))
                        {
                            return drinkId;
                        }
                    }
                }
            }

            return -1; // Drink not found
        }
    }
}
