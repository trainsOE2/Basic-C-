using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;
using RealEstate.Properties;
using MongoDB.Bson;

namespace RealEstate.Controllers
{
    public class HomeController : Controller
    {
        public IMongoDatabase database;
        public MongoServer server;
        public HomeController()
        {
            var client = new MongoClient(Settings.Default.RealEstateConnectionString);
            var server = new MongoClient(Settings.Default.RealEstateConnectionString);
            database = server.GetDatabase(Settings.Default.RealEstateDatabaseName);
        }
        public ActionResult Index()
        {
            return Json(database.server.BuildInfo, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}