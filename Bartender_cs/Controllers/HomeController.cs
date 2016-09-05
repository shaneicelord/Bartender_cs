using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bartender_cs;
using Bartender_cs.Models;

namespace Bartender_cs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCocktail()
        {
            Cocktail cocktail = new Cocktail();
            List<Cocktail> CocktailList = new List<Cocktail>();

            CocktailList = cocktail.GetCocktail();
            ViewData["Cocktail"] = CocktailList;

            return View();
        }
    }
}