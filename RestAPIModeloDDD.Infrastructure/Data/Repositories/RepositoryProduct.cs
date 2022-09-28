using RestAPIDDDModel.Domain.Core.Intefaces.Repositories;
using RestAPIModeloDDD.Domain.Entities;
using RestAPIModeloDDD.Infrastructure.Data;

namespace RestAPIDDDModel.Infrastructure.Data.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduct(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}