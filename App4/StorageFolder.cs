using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Diagnostics;
using App4.Core;
using System.IO;

namespace App4
{
    public class StorageFolder
    {
        public static string GetPath()
        {
            

            // Check if the file is already present in the Local folder
            var localFolder = ApplicationData.Current.LocalFolder;
            //var existingFile = await localFolder.TryGetItemAsync("strongroomDb.db");
            //string path;

            //if (existingFile == null)
            //{
            //    // Copy the file from the install folder to the local folder
            //    //var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            //    //var file = await folder.GetFileAsync("strongroomDb.db");
            //    //if (file != null)
            //    //{
            //    //    await file.CopyAsync(localFolder, "strongroomDb.db", NameCollisionOption.FailIfExists);
            //    //}

            //    //path = SqliteDataAccess.CreateDatabase(localFolder.Path);
            //} else
            //{
            //    var strongroomDb = await localFolder.TryGetItemAsync("strongroomDb.db");

            //    path = strongroomDb.Path;
            //}

            string databasePath = Path.Combine(localFolder.Path, "strongroomDb.db");


            Debug.WriteLine(databasePath);
            CreateConnectionString(databasePath);
            return databasePath;
        }

        public static void CreateConnectionString(string DbPath)
        {
            try
            {
                
               

                //Create the connection string using the connection builder
                SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder();

                string concat =  DbPath ;

                connectionBuilder.ConnectionString = concat;

                //Open the app.config for modification
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //Retreive connection string setting
                var connectionString = config.ConnectionStrings.ConnectionStrings["LocalFolderDb"];
                if (connectionString == null)
                {
                    //Create connection string if it doesn't exist
                    config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings
                    {
                        Name = "LocalFolderDb",
                        ConnectionString = connectionBuilder.ConnectionString,
                        ProviderName = "System.Data.SqlClient" //Depends on the provider, this is for SQL Server
                    });
                }
                else
                {
                    //Only modify the connection string if it does exist
                    connectionString.ConnectionString = connectionBuilder.ConnectionString;
                }

                //Save changes in the app.config
                //config.Save(ConfigurationSaveMode.Modified);
            }
            catch (Exception e)
            {
                //TODO: Handle exception
                Console.WriteLine(e.Message);
            }
        }

    }
}
