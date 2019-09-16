using App4.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4.Core.Services
{
    public static class ItemsServices
    {
        private static string GetConnectionString()
        {
            // Attempt to get the connection string from a config file
            // Learn more about specifying the connection string in a config file at https://docs.microsoft.com/en-us/dotnet/api/system.configuration.configurationmanager?view=netframework-4.7.2
            var conStr = ConfigurationManager.ConnectionStrings["MyAppConnectionString"]?.ConnectionString;

            if (!string.IsNullOrWhiteSpace(conStr))
            {
                return conStr;
            }
            else
            {
                // If no connection string is specified in a config file, use this as a fallback.
                return @"Data Source=*server*\*instance*;Initial Catalog=*dbname*;Integrated Security=SSPI";
            }
        }

        

        // This method returns data with the same structure as the SampleDataService but based on the NORTHWIND sample database.
        // Use this as an alternative to the sample data to test using a different datasource without changing any other code.
        // TODO WTS: Remove this when or if it isn't needed.
        public static async Task<IEnumerable<Items>> AllItems()
        {
            // This hard-coded SQL statement is included to make this sample simpler.
            // You can use Stored procedure, ORMs, or whatever is appropriate to access data in your app.


            const string getSampleDataQuery2 = @"
            SELECT *
            FROM Users";


            var products = new List<Items>();

            try
            {
                using (var conn = new SqlConnection(GetConnectionString()))
                {
                    await conn.OpenAsync();

                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = getSampleDataQuery2;

                            using (var reader = await cmd.ExecuteReaderAsync())
                            {
                                while (await reader.ReadAsync())
                                {

                                    var product = new Items
                                    {
                                        Id = reader.GetInt32(0),
                                        Name = reader.GetString(1),
                                        Barcode = reader.GetInt32(2),
                                        Quantity = reader.GetInt32(3),
                                        Location = reader.GetString(4)
                                    };
                                    products.Add(product);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception eSql)
            {
                // Your code may benefit from more robust error handling or logging.
                // This logging is just a reminder that you should handle exceptions when connecting to remote data.
                System.Diagnostics.Debug.WriteLine($"Exception: {eSql.Message} {eSql.InnerException?.Message}");
            }

            return products;
        }
    }
}
