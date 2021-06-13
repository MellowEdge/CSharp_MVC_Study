using Lab6_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab6_1.Controllers
{
    public class HomeController : Controller
    {
        GameContext db = new GameContext();

        public ActionResult Index()
        {
            IEnumerable<Game> games = db.Games;
            ViewBag.Games = games;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.GameId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Thanks for choosing our shop, " + purchase.Person + "!";
        }
    }
}