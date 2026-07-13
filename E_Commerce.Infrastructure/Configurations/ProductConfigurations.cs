using E_Commerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace E_Commerce.Infrastructure.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x => x.ProductBrand).WithMany().HasForeignKey(x=>x.BrandId);
            builder.HasOne(x => x.ProductType).WithMany().HasForeignKey(x=>x.TypeId);

            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");

        }
    }
}
