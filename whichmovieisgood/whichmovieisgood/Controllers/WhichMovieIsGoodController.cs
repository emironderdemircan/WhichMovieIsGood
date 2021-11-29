using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace whichmovieisgood.Controllers
{
    public class WhichMovieIsGoodController : Controller
    {
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

        public ViewResult SignUp()
        {
            return View();
        }
    }
}