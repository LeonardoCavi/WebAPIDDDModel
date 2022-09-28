using RestAPIDDDModel.Domain.Core.Intefaces.Repositories;
using RestAPIDDDModel.Domain.Core.Intefaces.Services;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIDDDModel.Domain.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient repositoryClient;

        public ServiceClient(IRepositoryClient repositoryClient) : base(repositoryClient)
        {
            this.repositoryClient = repositoryClient;
        }
    }
}