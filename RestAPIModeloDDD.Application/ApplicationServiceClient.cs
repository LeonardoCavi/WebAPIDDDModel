using RestAPIDDDModel.Application.DTOs;
using RestAPIDDDModel.Application.Interfaces;
using RestAPIDDDModel.Application.Interfaces.Mappers;
using RestAPIDDDModel.Domain.Core.Intefaces.Services;

namespace RestAPIDDDModel.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapperClient mapperClient;

        public ApplicationServiceClient(IServiceClient serviceClient, IMapperClient mapperClient)
        {
            this.serviceClient = serviceClient;
            this.mapperClient = mapperClient;
        }

        public void Add(DTOClient dtoClient)
        {
            var client = mapperClient.MapperDtoToEntity(dtoClient);
            serviceClient.Add(client);
        }

        public IEnumerable<DTOClient> GetAll()
        {
            var clients = serviceClient.GetAll();
            return mapperClient.MapperListDTOClients(clients);
        }

        public DTOClient? GetById(int id)
        {
            var client = serviceClient.GetById(id);
            return mapperClient.MapperEntityToDto(client);
        }

        public void Remove(DTOClient dtoClient)
        {
            var client = mapperClient.MapperDtoToEntity(dtoClient);
            serviceClient.Remove(client);
        }

        public void Update(DTOClient dtoClient)
        {
            var client = mapperClient.MapperDtoToEntity(dtoClient);
            serviceClient.Update(client);
        }
    }
}