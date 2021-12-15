using Microsoft.EntityFrameworkCore;
using hatSimulator.Models;
// adding namespace hatContext.Data breaks this. 
    public class HatContext : DbContext
    {
        public DbSet<Hat> Hats {get; set;}
        public DbSet<Phone> Phones {get; set;}
        // public string db
        public HatContext(DbContextOptions<HatContext> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CONNECTION_INFO_STRING"));
            
    }
#pragma warning restore format