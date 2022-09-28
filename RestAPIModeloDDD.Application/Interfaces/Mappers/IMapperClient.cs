using RestAPIDDDModel.Application.DTOs;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIDDDModel.Application.Interfaces.Mappers
{
    public interface IMapperClient
    {
        Client MapperDtoToEntity(DTOClient dtoClient);

        IEnumerable<DTOClient> MapperListDTOClients(IEnumerable<Client> clients);

        DTOClient? MapperEntityToDto(Client? client);
    }
}