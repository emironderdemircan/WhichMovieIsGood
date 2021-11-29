using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using whichmovieisgood.Models;

namespace whichmovieisgood.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
    }
}