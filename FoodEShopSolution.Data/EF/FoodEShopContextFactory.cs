using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoodEShopSolution.Data.EF
{
    public class FoodEShopContextFactory : IDesignTimeDbContextFactory<FoodEShopDbContext>
    {
        public FoodEShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();

            var connectionString = configuration.GetConnectionString("FoodEShopSolutionDb");

            var optionBuilder = new DbContextOptionsBuilder<FoodEShopDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new FoodEShopDbContext(optionBuilder.Options);
        }
    }
}
