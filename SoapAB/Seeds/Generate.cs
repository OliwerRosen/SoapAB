using Microsoft.EntityFrameworkCore;
using SoapAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoapAB.Seeds
{
    public class Generate
    {
        public static List<Article> Articles { get; set; } = new();
        public static List<ArticleType> ArticleTypes { get; set; } = new();
        public static Random rnd = new Random();
        public static List<ArticleType> CreateArticleTypes()
        {
            CreateArticleType( "Red", "This is a nice soap");
            CreateArticleType( "Blue", "This is a shiny, tasty soap");
            CreateArticleType( "White", "This soap will make you clean");
            CreateArticleType( "Yellow", "This is one of the best soaps we have");
            return ArticleTypes;
        }
        private static void CreateArticleType(string name, string description)
        {
            ArticleType Type = new ArticleType()
            {
                Name = name,
                Price = rnd.Next(50, 101),
                Description = description,
            };
            ArticleTypes.Add(Type);
        }
        
        public static List<Article> CreateArticles(int nrOfArticles)
        {
            for (int i = 0; i < nrOfArticles; i++)
            {
                int RandNr = rnd.Next(ArticleTypes.Count());
                var article = new Article
                {
                    IsInStock = true,
                    DateArrivedToStock = DateTime.Today.ToString(),
                    DateSentFromStock = null,
                    ArticleType = ArticleTypes[RandNr],
                };
                Articles.Add(article);
            }
            return Articles;
        }
    }
}
