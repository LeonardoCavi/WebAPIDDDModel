using RestAPIDDDModel.Domain.Core.Intefaces.Repositories;
using RestAPIDDDModel.Domain.Core.Intefaces.Services;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIDDDModel.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct) : base(repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }
    }
}