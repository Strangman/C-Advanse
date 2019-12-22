using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task01.Models;

namespace Task01
{
    public class Task01Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            IConfigurationRoot configuratoin = new ConfigurationBuilder()
                .SetBasePath(@"C:\Users\Strangman\source\repos\Homework13\Task01")
                .AddJsonFile("appsettings.json")
                .Build();
            optionBuilder.UseSqlServer(configuratoin.GetConnectionString("NetCoreWebAppContext"));
        }
        public DbSet<Character> Characters { get; set; }
    }
}
