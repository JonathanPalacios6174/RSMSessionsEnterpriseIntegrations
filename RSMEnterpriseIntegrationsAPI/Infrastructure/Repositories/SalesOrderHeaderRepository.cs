using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Infrastructure.Repositories
{
    public class SalesOrderHeaderRepository:ISalesOrderHeaderRepository
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

        public Task<SalesOrderHeader?> GetSalesOrderHeaderById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateSalesOrderHeader(SalesOrderHeader salesOrderHeader)
        {
            throw new NotImplementedException();
        }
    }
}
