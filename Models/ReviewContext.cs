
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RESTauranter.Models
{
    public class ReviewContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along.
        public ReviewContext(DbContextOptions options) : base(options) { }

        public DbSet<Recensione> reviews { get; set; }
    }
}