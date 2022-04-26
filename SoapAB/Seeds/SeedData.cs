using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SoapAB.Data;
using SoapAB.Models;


namespace SoapAB.Seeds
{
    public enum ArticleTypeNames { Red, Blue, Yellow, White };
    //using (var context = new DBContext(
    //            serviceProvider.GetRequiredService<
    //                DbContextOptions<DBContext>>()));
    public class SeedData
    {
        private readonly SoapDBContext _db;
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SoapDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<SoapDBContext>>()))
            {
                if (context.Database != null)
                {
                    return;
                }
                context.Database.EnsureDeleted();
                context.Database.Migrate();
                int numberOfArticles = 100;
                var range = Generate.CreateArticleTypes();
                foreach (ArticleType articleType in range)
                {
                    context.ArticleType.Add(articleType);
                }
                
                await context.SaveChangesAsync();

                context.Article.AddRange(Generate.CreateArticles(numberOfArticles));
                await context.SaveChangesAsync();
            }
        } 
    }
}
