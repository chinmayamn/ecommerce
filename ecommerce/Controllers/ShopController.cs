using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ecommerce.Models;
using Newtonsoft.Json;
using System.IO;
using System.Data;
using System.Web.Routing;

namespace ecommerce.Controllers
{
    public class ShopController : Controller
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

        [Route("shop/shipping_information")]
        [Route("shop/exchange")]
        [Route("shop/terms_conditions")]
        [Route("shop/privacy_policy")]
        public ActionResult CMS()
        {
            string CurrentAction = Request.RawUrl;
            if (CurrentAction == "/shop/shipping_information")
            {
                ViewBag.Title = "Shipping Information";
                ViewBag.text = "shipping";
            }
            else if (CurrentAction == "/shop/exchange")
            {
                ViewBag.Title = "Return & Exchange";
                ViewBag.text = "exchange";
            }
            else if (CurrentAction == "/shop/terms_conditions")
            {
                ViewBag.Title = "Terms & Conditions";
                ViewBag.text = "terms and conditions";
            }
            else
            {
                ViewBag.Title = "Privacy Policy";
                ViewBag.text = "privacy policy";
            }
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
        [Route("shop/products/{cat}")]
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
        [Route("shop/Products")]
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