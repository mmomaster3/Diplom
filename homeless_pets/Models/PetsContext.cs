using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace homeless_pets.Models
{
    public class PetsContext : DbContext
    {
        public PetsContext() : base("DefaultConnection")
        { }
        public DbSet<Pet> Pets { get; set; }
    }
}