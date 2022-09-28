using RestAPIDDDModel.Application.DTOs;
using RestAPIDDDModel.Application.Interfaces.Mappers;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIDDDModel.Infrastructure.CrossCutting.Mapper
{
    public class MapperClient : IMapperClient
    {
        public Client MapperDtoToEntity(DTOClient dtoClient)
        {
            var client = new Client()
            {
                Id = dtoClient.Id,
                Name = dtoClient.Name,
                LastName = dtoClient.LastName,
                Email = dtoClient.Email
            };

            return client;
        }

        public DTOClient? MapperEntityToDto(Client client)
        {
            var dtoClient = new DTOClient()
            {
                Id = client.Id,
                Name = client.Name,
                LastName = client.LastName,
                Email = client.Email
            };

            return dtoClient;
        }

        public IEnumerable<DTOClient> MapperListDTOClients(IEnumerable<Client> clients)
        {
            var dto = clients.Select(c => new DTOClient
            {
                Id = c.Id,
                Name = c.Name,
                LastName = c.LastName,
                Email = c.Email
            });

            return dto;
        }
    }
}