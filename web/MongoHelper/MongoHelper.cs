using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.MongoHelper
{
    public class MongoHelper
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://thanhho200404:oJSNu0AwwBuPfeDK@web.wce7l.mongodb.net/?retryWrites=true&w=majority&appName=web";
        public static string MongoDatabase = "web";
        public static IMongoCollection<Models.Product> product_collection { get; set; }
        public static IMongoCollection<Models.User> user_collection { get; set; }
        internal static void ConnectToMongoService()
        {
            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);
            }
            catch (Exception)
            {
                //heloo
                throw;
            }
        }
    }
}