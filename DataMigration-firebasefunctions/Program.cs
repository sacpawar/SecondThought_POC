using Google.Cloud.Firestore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace DataMigration_firebasefunctions
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            string baseUrl = "https://us-central1-carbon-modem-290607.cloudfunctions.net/app";
            var filePath = "E://SachinPawar//Second-Thought//SecondThought_POC//DataMigration-firebasefunctions//Data//";
            int count = 0;
            var jsonFiles = Directory.EnumerateFiles(filePath);
            foreach (var jsonFile in jsonFiles)
            {
                Console.WriteLine($"File {jsonFile.Split("//")[jsonFile.Split("//").Length - 1]} started!");

                try
                {
                    var dataString = File.ReadAllText(jsonFile);
                    var productMaster = JsonConvert.DeserializeObject<Product>(dataString);
                    foreach (var product in productMaster.Items)
                    {
                        using (var client = new HttpClient())
                        {
                            //client.DefaultRequestHeaders.Accept.Clear();
                            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                            var myContent = JsonConvert.SerializeObject(product);
                            HttpContent content = new StringContent(myContent, Encoding.UTF8, "application/json");

                            var response = await client.PutAsync($"{baseUrl}/products/addproduct", content);
                            if (response.IsSuccessStatusCode)
                            {
                                count++;
                                var data = await response.Content.ReadAsStringAsync();
                                Console.WriteLine($"{count}-Status: {response.StatusCode}, Data:{data} ");
                                Uri siteUrl = response.Headers.Location;
                            }

                            //Console.WriteLine("Get");
                            //var products = await client.GetAsync($"{baseUrl}/products");
                            //if (products.IsSuccessStatusCode)
                            //{
                            //    var sites = await products.Content.ReadAsStringAsync();
                            //    Console.WriteLine(sites);
                            //}
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                Console.WriteLine($"File {jsonFile.Split("//")[jsonFile.Split("//").Length - 1]} is completed!");
                Console.WriteLine($"Total count: {count}");
                count = 0;
            }

            Console.WriteLine($"Data migration completed!");
            Console.ReadKey();
        }
    }

    [FirestoreData]
    public class Product
    {
        [FirestoreProperty] public int PageIndex { get; set; }
        [FirestoreProperty] public int PageSize { get; set; }
        [FirestoreProperty] public int TotalItemCount { get; set; }
        [FirestoreProperty] public List<object> Items { get; set; } = new List<object>();
    }
}
