using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace homeless_pets.Models
{
    public class NewsContext : DbContext
    {
        public NewsContext() : base("DefaultConnection")
        { }
        public DbSet<New> News { get; set; }
    }
}