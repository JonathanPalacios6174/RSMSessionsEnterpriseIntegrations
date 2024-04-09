using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Infrastructure.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable(nameof(ProductCategory), "Production");
            builder.HasKey(p => p.ProductCategoryID);
            builder.Property(p => p.ProductCategoryID).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.rowguid).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("NEWID()");
            builder.Property(p => p.ModifiedDate).HasDefaultValueSql("GETDATE()");
        }
    }
}
