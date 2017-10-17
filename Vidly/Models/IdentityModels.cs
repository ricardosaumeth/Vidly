using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class IdentityModels: DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}