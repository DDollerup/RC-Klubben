using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RefresherCourse.Models;
using RefresherCourse.Factories;

namespace RefresherCourse.Controllers
{
    public class HomeController : Controller
    {
        private DBContext context = DBContext.Instance;

        public ActionResult Index()
        {
            return View(context.IndexFactory.Get(1));
        }

        [ChildActionOnly]
        public ActionResult Slider()
        {
            return PartialView(context.SliderFactory.GetAll());
        }

        [ChildActionOnly]
        public ActionResult CategoryLinks()
        {
            return PartialView(context.CategoryFactory.GetAll());
        }

        [ChildActionOnly]
        public ActionResult NewestProducts()
        {
            return PartialView(context.ProductFactory.GetAll().OrderByDescending(x => x.ID).Take(5).ToList());
        }

        [ChildActionOnly]
        public ActionResult NewestEvents()
        {
            return PartialView(context.EventFactory.GetAll().OrderByDescending(x => x.Date).Take(5).ToList());
        }

        [HttpPost]
        public ActionResult Search(string searchQuery)
        {
            if (string.IsNullOrEmpty(searchQuery))
            {
                TempData["Result"] = new List<Product>();
            }
            else
            {
                TempData["Result"] = context.ProductFactory.SearchBy(searchQuery, "Title", "Manufacturer", "Fuel", "Content");
            }
            
            return RedirectToAction("Products");
        }

        // id = Category.ID
        public ActionResult Products(int id = 0)
        {
            if (id > 0)
            {
                return View(context.ProductFactory.GetAllBy("CategoryID", id));
            }
            else
            {
                return View(TempData["Result"] as List<Product>);
            }
        }

        // id = Product.ID
        public ActionResult ShowProduct(int id)
        {
            return View(context.ProductFactory.Get(id));
        }

        public ActionResult Events()
        {
            List<Event> allEvents = context.EventFactory.GetAll();
            return View(allEvents.OrderByDescending(x => x.Date).ToList());
        }

        // id = Event.ID
        public ActionResult ShowEvent(int id)
        {
            return View(context.EventFactory.Get(id));
        }

        public ActionResult About()
        {
            return View(context.AboutFactory.Get(1));
        }
    }
}