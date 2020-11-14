using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ecommerce.Models;
using Newtonsoft.Json;
using System.IO;
using System.Data;

namespace ecommerce.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            List<Products> pp = new List<Models.Products>();
            Products p = new Products();
            string jsonString = System.IO.File.ReadAllText(Server.MapPath("~/js/data.js"));
            List<Products> plist = JsonConvert.DeserializeObject<List<Products>>(jsonString);
            return View(plist.Take(8));
        }


        public ActionResult About()
        {


            return View();
        }

        public ActionResult Login()
        {


            return View();
        }

        public ActionResult Contact()
        {


            return View();
        }

        [HttpGet]
        [Route("Home/DirectProducts/{cat}")]
        public ActionResult DirectProducts(string cat)
        {
            List<Products> pp = new List<Models.Products>();
            Products p = new Products();
            string jsonString = System.IO.File.ReadAllText(Server.MapPath("~/js/data.js"));
            List<Products> plist = JsonConvert.DeserializeObject<List<Products>>(jsonString);
            plist = plist.Where(x => x.Category == cat).ToList();
            return View("products",plist);
        }

        [HttpGet]
        [Route("Home/Products")]
        public ActionResult Products()
        {
            List<Products> pp = new List<Models.Products>();
            Products p = new Products();
            string jsonString = System.IO.File.ReadAllText(Server.MapPath("~/js/data.js"));
            List<Products> plist = JsonConvert.DeserializeObject<List<Products>>(jsonString);
            return View(plist);
        }
      
        public ActionResult Cart()
        {
           
            return View();
        }
        public ActionResult Checkout()
        {
           

            return View();
        }
        public ActionResult ProductDetail(int? id)
        {
            List<Products> pp = new List<Models.Products>();
            Products p = new Products();
            string jsonString = System.IO.File.ReadAllText(Server.MapPath("~/js/data.js"));
            List<Products> plist = JsonConvert.DeserializeObject<List<Products>>(jsonString);
            p = plist.Find(x => x.Id == id);
            return View(p);
        }
    }
}