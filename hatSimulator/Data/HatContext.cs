using Microsoft.EntityFrameworkCore;
using hatSimulator.Models;
// adding namespace hatContext.Data breaks this. 
namespace hatSimulator.Data
{
    public class HatContext : DbContext
    {
        public HatContext(DbContextOptions<HatContext> options) : base(options) {}
        public DbSet<Hat> Hats {get; set;}
        public DbSet<Phone> Phones {get; set;}
        // public string db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CONNECTION_INFO_STRING"));
            }
            base.OnConfiguring(optionsBuilder);
        }
            
    }    
}

#pragma warning restore format