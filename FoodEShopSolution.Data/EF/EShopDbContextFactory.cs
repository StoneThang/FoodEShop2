using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoodEShopSolution.Data.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<FoodEShopDbContext>
    {
        public FoodEShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("FoodEShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<FoodEShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new FoodEShopDbContext(optionsBuilder.Options);
        }
    }
}
