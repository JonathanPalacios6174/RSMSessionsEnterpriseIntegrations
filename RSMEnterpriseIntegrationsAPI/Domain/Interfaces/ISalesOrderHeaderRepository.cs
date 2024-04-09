using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Domain.Interfaces
{
    public interface ISalesOrderHeaderRepository
    {
        Task<SalesOrderHeader?> GetSalesOrderHeaderById(int id);
        Task<IEnumerable<SalesOrderHeader>> GetAllSalesOrderHeaders();
        Task<int> CreateSalesOrderHeader(SalesOrderHeader salesOrderHeaderDto);
        Task<int> UpdateSalesOrderHeader(SalesOrderHeader salesOrderHeaderDto);
        Task<int> DeleteSalesOrderHeader(SalesOrderHeader salesOrderHeaderDto);
    }
}
