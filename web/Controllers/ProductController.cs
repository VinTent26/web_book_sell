using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                MongoHelper.MongoHelper.ConnectToMongoService();
                MongoHelper.MongoHelper.product_collection = MongoHelper.MongoHelper.database.GetCollection<Models.Product>("products");
                Object id = GenerateRandomId(24);
                MongoHelper.MongoHelper.product_collection.InsertOneAsync(new Models.Product
                {
                    _id= id,
                    Name = collection["Name"],
                    Description= collection["Description"],
                    Price= Convert.ToDouble(collection["Price"]),
                    Category= collection["Category"]
                });
                return null;
            }
            catch
            {
                return View();
            }
        }
        private Random random = new Random();
        private object GenerateRandomId(int v)
        {
            String strarray= "asdfghjklmbnvcxzqwertyuiop123456789";
            return new string(Enumerable.Repeat(strarray,v).Select(s=>s[random.Next(s.Length)]).ToArray());
        }



        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
