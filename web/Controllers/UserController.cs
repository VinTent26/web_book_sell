using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                MongoHelper.MongoHelper.ConnectToMongoService();
                MongoHelper.MongoHelper.user_collection = MongoHelper.MongoHelper.database.GetCollection<Models.User>("User");
                Object id = GenerateRandomId(24);
                MongoHelper.MongoHelper.user_collection.InsertOneAsync(new Models.User
                {
                    _id = id,
                    FirstName = collection["FirstName"],
                    LastName= collection["LastName"],
                    Adresss = collection["Adresss"],
                    Phone = collection["Phone"]
                });

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        private Random random = new Random();
        private object GenerateRandomId(int v)
        {
            String strarray = "asdfghjklmbnvcxzqwertyuiop123456789";
            return new string(Enumerable.Repeat(strarray, v).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
