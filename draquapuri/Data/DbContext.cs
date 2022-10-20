using draquapuri.Model;
using Microsoft.EntityFrameworkCore;

namespace draquapuri.Data
{
    public class DbContexts : DbContext
    {
        public DbContexts(DbContextOptions<DbContexts> options) : base(options)
        {

        }

        public DbSet<Login>? Login { get; set; }
        //public DbSet<Products>? Products { get; set; }
        public DbSet<Inquiry>? Inquiry { get; set; }

        public DbSet<Products>? Products { get; set; }
        public DbSet<ProductImage>? ProductImage { get; set; }


    }
}
