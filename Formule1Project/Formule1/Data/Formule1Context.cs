
using Microsoft.EntityFrameworkCore;
using F1Lib.Models;

namespace F1MVC.Data
{
    public class Formule1Context : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Circuit> Circuit { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Grandprix> Grandprix { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Team> Teams { get; set; }

        public Formule1Context(DbContextOptions<Formule1Context> options) : base(options)
        {

        }
    }
}

