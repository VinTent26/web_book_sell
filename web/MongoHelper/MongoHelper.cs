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
        public static string MongoConnection = "mongodb+srv://bookweb:Qm0pI1dvJYK5abDe@cluster0.ghoos.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
        public static string MongoDatabase = "web_book";
        public static IMongoCollection<Models.Product> product_collection { get; set; }
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