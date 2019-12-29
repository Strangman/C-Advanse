using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectV2.Data
{
    public class ProjectV2Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(@"C:\Users\Strangman\source\repos\ProjectV2\ProjectV2")
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("NetCoreWebAppContext"));
        }
        public ProjectV2Context()
        {
            Database.EnsureCreated();
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<News_single> News { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<DLC> DLCs { get; set; }
    }
}
