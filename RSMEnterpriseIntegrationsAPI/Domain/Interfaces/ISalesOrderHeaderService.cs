using RSMEnterpriseIntegrationsAPI.Application.DTOs;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Domain.Interfaces
{
    public interface ISalesOrderHeaderService
    {
        Task<SalesOrderHeader?> GetSalesOrderHeaderServiceById(int id);
        Task<IEnumerable<SalesOrderHeader>> GetAllSalesOrderHeaders();
        Task<int> CreateSalesOrderHeader(CreateSalesOrderHeaderDto salesOrderHeaderDto);
        Task<int> UpdateSalesOrderHeader(UpdateSalesOrderHeaderDto salesOrderHeaderDto);
        Task<int> DeleteSalesOrderHeader(int id);
    }
}
