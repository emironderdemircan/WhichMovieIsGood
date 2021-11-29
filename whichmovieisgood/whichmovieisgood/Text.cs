using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using whichmovieisgood.DataContext;

namespace whichmovieisgood
{
    public class Text
    {
        public Text()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Database.CreateIfNotExists();
        }
    }
}