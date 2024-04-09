using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Infrastructure.Configurations
{
    public class SalesOrderHeaderConfiguration : IEntityTypeConfiguration<SalesOrderHeader>
    {
        public void Configure(EntityTypeBuilder<SalesOrderHeader> builder)
        {
            builder.ToTable(nameof(SalesOrderHeader), "Sales");

            builder.HasKey(e => e.SalesOrderID);
            builder.Property(e => e.SalesOrderID).HasColumnName("SalesOrderID").ValueGeneratedOnAdd();
            builder.Property(e => e.OrderDate).HasColumnName("OrderDate").IsRequired();
            builder.Property(e => e.DueDate).HasColumnName("DueDate").IsRequired();
            builder.Property(e => e.ShipDate).HasColumnName("ShipDate");
            builder.Property(e => e.Status).HasColumnName("Status").IsRequired();
            builder.Property(e => e.OnlineOrderFlag).HasColumnName("OnlineOrderFlag").IsRequired();
            builder.Property(e => e.SalesOrderNumber).HasColumnName("SalesOrderNumber");
            builder.Property(e => e.PurchaseOrderNumber).HasColumnName("PurchaseOrderNumber");
            builder.Property(e => e.AccountNumber).HasColumnName("AccountNumber");
            builder.Property(e => e.CustomerID).HasColumnName("CustomerID").IsRequired();
            builder.Property(e => e.SalesPersonID).HasColumnName("SalesPersonID");
            builder.Property(e => e.TerritoryID).HasColumnName("TerritoryID");
            builder.Property(e => e.BillToAddressID).HasColumnName("BillToAddressID").IsRequired();
            builder.Property(e => e.ShipToAddressID).HasColumnName("ShipToAddressID").IsRequired();
            builder.Property(e => e.ShipMethodID).HasColumnName("ShipMethodID").IsRequired();
            builder.Property(e => e.CreditCardID).HasColumnName("CreditCardID");
            builder.Property(e => e.CreditCardApprovalCode).HasColumnName("CreditCardApprovalCode");
            builder.Property(e => e.CurrencyRateID).HasColumnName("CurrencyRateID");
            builder.Property(e => e.SubTotal).HasColumnName("SubTotal").IsRequired();
            builder.Property(e => e.TaxAmt).HasColumnName("TaxAmt").IsRequired();
            builder.Property(e => e.Freight).HasColumnName("Freight").IsRequired();
            builder.Property(e => e.TotalDue).HasColumnName("TotalDue");
            builder.Property(e => e.Comment).HasColumnName("Comment");
            builder.Property(e => e.rowguid).HasColumnName("rowguid").IsRequired();
            builder.Property(e => e.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
