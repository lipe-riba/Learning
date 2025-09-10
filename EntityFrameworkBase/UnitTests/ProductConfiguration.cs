using System.Data.Entity;
using EntityFrameworkBase.Data.Contexts.Configurations;

namespace Tests
{
    public class ProductConfiguration : BaseEntityConfiguration
    {
        public ProductConfiguration(DbModelBuilder modelBuilder)
            : base(modelBuilder)
        {
            modelBuilder.Entity<Product>();
        }
    }
}
