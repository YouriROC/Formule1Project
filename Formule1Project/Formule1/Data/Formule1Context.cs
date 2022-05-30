using F1Lib.Models;
using F1Lib.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

 

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
        public DbSet<WinnerVM> Winners { get; set; }
        public DbSet<YearDistinct> YearDistinct { get; set; }

        public Formule1Context(DbContextOptions<Formule1Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<WinnerVM>().ToView("spWinnerscIRCUIT").HasNoKey();

        }

    }
}

