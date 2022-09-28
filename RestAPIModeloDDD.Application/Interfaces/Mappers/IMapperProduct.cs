using RestAPIDDDModel.Application.DTOs;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIDDDModel.Application.Interfaces.Mappers
{
    public interface IMapperProduct
    {
        Product MapperDtoToEntity(DTOProduct dtoProduct);

        IEnumerable<DTOProduct> MapperListDTOClients(IEnumerable<Product> products);

        DTOProduct? MapperEntityToDto(Product? product);
    }
}