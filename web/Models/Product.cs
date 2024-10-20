using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Models
{
    public class Product
    {
        public Object _id { get; set; }
        public string Name { get; set; }

        public string Description{ get; set; }

        public double Price{ get; set; }

        public string Category { get; set; }
    }
}