using RSMEnterpriseIntegrationsAPI.Application.DTOs;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Application.Services
{
    public class SalesOrderHeaderService : ISalesOrderHeaderService
    {
        
        public Task<int> CreateSalesOrderHeader(CreateSalesOrderHeaderDto salesOrderHeaderDto)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteSalesOrderHeader(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SalesOrderHeader>> GetAllSalesOrderHeaders()
        {
            throw new NotImplementedException();
        }

        public Task<SalesOrderHeader?> GetSalesOrderHeaderServiceById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateSalesOrderHeader(UpdateSalesOrderHeaderDto salesOrderHeaderDto)
        {
            throw new NotImplementedException();
        }
    }
}
