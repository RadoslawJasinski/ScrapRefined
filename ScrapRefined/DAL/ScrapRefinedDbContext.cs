using Microsoft.EntityFrameworkCore;
using ScrapRefined.Models;

namespace ScrapRefined.DAL
{
    public class ScrapRefinedDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<UserFavouriteProduct> UserFavouriteProducts { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }

        public ScrapRefinedDbContext()
        {

        }

        private const string connectionString = "server=b3yn61cgu2tobfh6ucav-mysql.services.clever-cloud.com;user=uwb5qvtpbuot26p1;password=Dml5uTzLt1asLNBnVRzP;database=b3yn61cgu2tobfh6ucav;SSL Mode=None";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }

}
