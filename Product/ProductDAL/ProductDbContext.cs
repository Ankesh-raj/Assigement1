using Microsoft.EntityFrameworkCore;
using ProductEntity;
using System;

namespace ProductDAL
{
    public class ProductDbContext:DbContext
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Article> tblArticle { get; set; }
        public DbSet<Color> tblColor { get; set; }
        public DbSet<Product> tblProduct { get; set; }
        public DbSet<SizeScale> tblSizeScale { get; set; }
                

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2151; Initial Catalog =Product_Demo1; Integrated Security=True;");
        }
    }
}
