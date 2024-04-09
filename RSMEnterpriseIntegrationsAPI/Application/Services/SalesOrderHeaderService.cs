using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Application.Services
{
    public class SalesOrderHeaderService:ISalesOrderHeaderService
    {
        public Task<int> CreateSalesOrderHeader(SalesOrderHeader salesOrderHeader)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteSalesOrderHeader(SalesOrderHeader salesOrderHeader)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SalesOrderHeader>> GetAllSalesOrderHeaders()
        {
            throw new NotImplementedException();
        }

        public Task<SalesOrderHeader?> GetSalesById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateSalesOrderHeader(SalesOrderHeader salesOrderHeader)
        {
            throw new NotImplementedException();
        }
    }
}
