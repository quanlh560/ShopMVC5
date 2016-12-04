using System.Data.Entity;
using TeduShop.Model.Models;

namespace TeduShop.Data

{
    public class TeduShopDbContext : DbContext
    {
        public TeduShopDbContext() : base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        //public DbSet<Footer> Footers { set; get; }
    }
}