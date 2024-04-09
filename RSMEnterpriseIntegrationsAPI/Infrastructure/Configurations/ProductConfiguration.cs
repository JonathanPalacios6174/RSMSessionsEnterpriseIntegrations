
namespace RSMEnterpriseIntegrationsAPI.Infrastructure.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using RSMEnterpriseIntegrationsAPI.Domain.Models;
    public class ProductConfiguration:IEntityTypeConfiguration<Domain.Models.Product>
    {
        public void Configure(EntityTypeBuilder<Domain.Models.Product> builder)
        {
            builder.ToTable("Product", "Production");
            builder.HasKey(p => p.ProductID);
            builder.Property(p => p.ProductID).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.ProductNumber).IsRequired().HasMaxLength(25);
            builder.Property(p => p.MakeFlag).IsRequired();
            builder.Property(p => p.FinishedGoodsFlag).IsRequired();
            builder.Property(p => p.ReorderPoint).IsRequired();
            builder.Property(p => p.StandardCost).HasColumnType("money").IsRequired();
            builder.Property(p => p.ListPrice).HasColumnType("money").IsRequired();
            builder.Property(p => p.Size).HasMaxLength(5);
            builder.Property(p => p.SizeUnitMeasureCode).HasMaxLength(3);
            builder.Property(p => p.WeightUnitMeasureCode).HasMaxLength(3);
            builder.Property(p => p.DaysToManufacture).IsRequired();
            builder.Property(p => p.ProductLine).HasMaxLength(2);
            builder.Property(p => p.Class).HasMaxLength(2);
            builder.Property(p => p.Style).HasMaxLength(2);
            builder.Property(p => p.SellStartDate).IsRequired();
            builder.Property(p => p.rowguid).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("NEWID()");
            builder.Property(p => p.ModifiedDate).IsRequired().HasDefaultValueSql("GETDATE()");
        }
    }
}
