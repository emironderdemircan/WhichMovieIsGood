using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using whichmovieisgood.Models.Entity;

namespace whichmovieisgood.Controllers
{
    public class WhichMovieIsGoodController : Controller
    {
        whichmovieisgooddatabaseEntities db = new whichmovieisgooddatabaseEntities();
        // GET: WhichMovieIsGood
        public ViewResult AnaSayfa()
        {
            Text a = new Text();
            return View();
        }

        public ViewResult YeniCıkanlar()
        {
            return View();
        }

        public ViewResult Iletisim()
        {
            return View();
        }

        public ViewResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SingIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SingIn(TBLKISILER p1)
        {
            db.TBLKISILER.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}