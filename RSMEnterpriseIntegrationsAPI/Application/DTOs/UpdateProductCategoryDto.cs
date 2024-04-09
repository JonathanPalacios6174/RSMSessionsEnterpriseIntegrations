namespace RSMEnterpriseIntegrationsAPI.Application.DTOs
{
    public class UpdateProductCategoryDto
    {
        public int? ProductCategoryID { get; set; }
        public string? Name { get; set; }
        public Guid rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
