using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoapAB.Areas.Identity.Data;
using SoapAB.Models;

namespace SoapAB.Data
{
    public class SoapDBContext : IdentityDbContext<AppUser>
    {
        public SoapDBContext(DbContextOptions<SoapDBContext> options)
            : base(options)
        {

        }
        public DbSet<ArticleType> ArticleType { get; set; }
        public DbSet<Article> Article { get; set; }
    }
}
