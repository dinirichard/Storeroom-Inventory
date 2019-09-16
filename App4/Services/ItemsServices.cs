using App4.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4.Services
{
    class ItemsServices
    {
        public ObservableCollection<Items> GetProducts(string connectionString)
        {
            const string GetProductsQuery = "select ProductID, ProductName, QuantityPerUnit," +
               " UnitPrice, UnitsInStock, Products.CategoryID " +
               " from Products inner join Categories on Products.CategoryID = Categories.CategoryID " +
               " where Discontinued = 0";

            var products = new ObservableCollection<Items>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = GetProductsQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var product = new Items();
                                    product.Id = reader.GetInt32(0);
                                    product.Name = reader.GetString(1);
                                    product.Barcode = reader.GetInt32(2);
                                    product.Quantity = reader.GetInt32(3);
                                    product.Location = reader.GetString(4);
                                    products.Add(product);
                                }
                            }
                        }
                    }
                }
                return products;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;
        }
    }
}
