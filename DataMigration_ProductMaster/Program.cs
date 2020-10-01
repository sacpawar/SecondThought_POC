using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace DataMigration_ProductMaster
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //Access permission
            string path = AppDomain.CurrentDomain.BaseDirectory + @"token-file.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            //Create instent of collection
            FirestoreDb db = await FirestoreDb.CreateAsync("eteva-firestore-app");
            CollectionReference masterCollection = db.Collection("ProductMaster");

            //var productCount = masterCollection.GetSnapshotAsync().Result.Count();
            //Console.WriteLine($"Total recors in collection is {productCount}");

            var filePath = "E://SachinPawar//Second-Thought//SecondThought_POC//DataMigration_ProductMaster//Data//";
            var jsonFiles = Directory.EnumerateFiles(filePath);
            WriteBatch batch = db.StartBatch();
            int count = 0;
            int batchCount = 0;
            //var original = new List<string>();
            //var duplicate = new List<string>();
            Console.WriteLine("Data migration started in batches of 500 record each...");
            foreach (var jsonFile in jsonFiles)
            {
                try
                {
                    Console.WriteLine($"File : {jsonFile.Split("//")[jsonFile.Split("//").Length - 1]} ----------->");
                    var dataString = File.ReadAllText(jsonFile);
                    var productMaster = JsonConvert.DeserializeObject<Product>(dataString);

                    foreach (var master in productMaster.Items)
                    {
                        #region To find duplicate records in a file

                        //if (original.Contains(master.TradeItem.Gtin))
                        //    duplicate.Add(master.TradeItem.Gtin);
                        //else
                        //    original.Add(master.TradeItem.Gtin);

                        #endregion

                        count += 1;
                        batch.Set(masterCollection.Document(master.TradeItem.Gtin), master);
                        if (count == 500)
                        {
                            batchCount++;
                            var result = await batch.CommitAsync();
                            Console.WriteLine($"Batch {batchCount} of {count} records are completed!");
                            batch = db.StartBatch();
                            count = 0;
                        }
                    }
                    if (count > 0)
                    {
                        var result = await batch.CommitAsync();
                        Console.WriteLine($"Batch {batchCount} of {count} records are completed!");
                        batch = db.StartBatch();
                    }
                    batchCount = 0;
                    //Console.WriteLine("Original record:" + original.Count());
                    //Console.WriteLine("Duplicate record:" + duplicate.Count());
                    //duplicate.ForEach(x => Console.WriteLine(x));

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error({e.Message}) occure in batch no {batchCount} of file {jsonFile}");
                    count = 0;
                    continue;
                }
            }
            Console.WriteLine($"Data migration completed!");

            //var productCount = masterCollection.GetSnapshotAsync().Result.Count();
            //Console.WriteLine($"Total recors in collection is {productCount}");

            Console.ReadKey();
        }
    }
}
