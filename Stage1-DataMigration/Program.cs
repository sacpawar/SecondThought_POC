using Google.Cloud.Firestore;
using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using Newtonsoft.Json.Linq;

namespace Stage1_DataMigration
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

            #region Migrate data from json files

            var filePath = "E://SachinPawar//Second-Thought//SecondThought_POC//Stage1-DataMigration//Data//";
            var jsonFiles = Directory.EnumerateFiles(filePath);
            WriteBatch batch1 = db.StartBatch();
            foreach (var jsonFile in jsonFiles)
            {
                var dataString = File.ReadAllText(jsonFile);
                var masterList = JsonConvert.DeserializeObject<List<Master>>(dataString);

                foreach (var master in masterList)
                {
                    //Batch---------->
                    batch1.Set(masterCollection.Document(), master);

                    //var model = masterCollection.WhereEqualTo("ean", master.ean);
                    //var snapshots = await model.GetSnapshotAsync();
                    //if (snapshots.Documents.Count > 0)
                    //{
                    //    await masterCollection.Document(snapshots.Documents[0].Id).SetAsync(master);
                    //    Console.WriteLine("Data Updated!");
                    //}
                    //else
                    //{
                    //    await masterCollection.Document().CreateAsync(master);
                    //    Console.WriteLine("Data Added!");
                    //}
                }
            }
            await batch1.CommitAsync();
            Console.WriteLine("Json file data imported to ProductMaster collection...");

            #endregion

            #region Read data from firestore

            //var data = await masterCollection.GetSnapshotAsync();
            //foreach (var document in data.Documents)
            //{
            //    var doc = document.ConvertTo<Master>();
            //    Console.WriteLine($"ean:{doc.ean} | document-id:{document.Id} | CreateTime:{document.CreateTime} ");
            //}

            #endregion

            #region MySQl opration read and write

            ////New connection
            //string connString = "datasource=localhost;port=3306;username=root;password=Admin";
            //MySqlConnection MyConnection = new MySqlConnection(connString);
            //CollectionReference surveyCollection = db.Collection("MYSQLImport");
            //MyConnection.Open();

            //string Query = "SELECT * FROM esurvey.survey";
            //MySqlCommand command = new MySqlCommand(Query, MyConnection);
            //MySqlDataReader reader = command.ExecuteReader();
            //var count = 0;

            //WriteBatch batch2 = db.StartBatch();
            //while (reader.Read())
            //{
            //    var model = new
            //    {
            //        CreatedOn = ((DateTime)reader["CreatedOn"]).ToUniversalTime(),
            //        Title = reader["Title"],
            //        Description = reader["Description"],
            //        Logo = reader["Logo"],
            //        Questions = reader["Questions"],
            //        Type_Id = reader["Type_Id"],
            //        NoOfSurveyResponses = reader["NoOfSurveyResponses"],
            //        Id = reader["Id"],
            //        LogoHeight = reader["LogoHeight"],
            //        LogoWidth = reader["LogoWidth"],
            //        User_Id = reader["User_Id"]
            //    };

            //    batch2.Set(surveyCollection.Document($"{reader["Id"]}"), model);
            //    count = count + 1;
            //}

            //await batch2.CommitAsync();

            //Console.WriteLine($"MySql record imported to MYSQLImport collection...");

            //MyConnection.Close();

            #endregion

            Console.ReadKey();
        }
    }

    [FirestoreData]
    public class Survey
    {
        [FirestoreProperty]
        public UInt64 Id { get; set; }
        [FirestoreProperty]
        public string Title { get; set; }
        [FirestoreProperty]
        public string Description { get; set; }
        [FirestoreProperty]
        public string Logo { get; set; }
        [FirestoreProperty]
        public string Questions { get; set; }
        [FirestoreProperty]
        public Int64 LogoWidth { get; set; }
        [FirestoreProperty]
        public Int64 LogoHeight { get; set; }
        [FirestoreProperty]
        public Int64 NoOfSurveyResponses { get; set; }
        [FirestoreProperty]
        public DateTime CreatedOn { get; set; }
        [FirestoreProperty]
        public Int32 Type_Id { get; set; }
        [FirestoreProperty]
        public Int64 User_Id { get; set; }
    }
}
