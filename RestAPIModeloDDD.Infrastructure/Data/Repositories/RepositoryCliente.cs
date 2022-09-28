using RestAPIDDDModel.Domain.Core.Intefaces.Repositories;
using RestAPIModeloDDD.Domain.Entities;
using RestAPIModeloDDD.Infrastructure.Data;

namespace RestAPIDDDModel.Infrastructure.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Client>, IRepositoryClient
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}