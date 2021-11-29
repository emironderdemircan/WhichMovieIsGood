using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace whichmovieisgood.Models.Manager
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Film> Filmler { get; set; }
    }

    public class Olusturucu : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
        }
    }
}