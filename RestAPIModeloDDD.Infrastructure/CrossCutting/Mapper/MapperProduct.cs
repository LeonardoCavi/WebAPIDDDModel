using RestAPIDDDModel.Application.DTOs;
using RestAPIDDDModel.Application.Interfaces.Mappers;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIDDDModel.Infrastructure.CrossCutting.Mapper
{
    public class MapperProduct : IMapperProduct
    {
        public Product MapperDtoToEntity(DTOProduct dtoProduct)
        {
            var product = new Product()
            {
                Id = dtoProduct.Id,
                Name = dtoProduct.Name,
                Value = dtoProduct.Value
            };

            return product;
        }

        public DTOProduct? MapperEntityToDto(Product? product)
        {
            var dtoProduct = new DTOProduct()
            {
                Id = product.Id,
                Name = product.Name,
                Value = product.Value
            };

            return dtoProduct;
        }

        public IEnumerable<DTOProduct> MapperListDTOClients(IEnumerable<Product> products)
        {
            var dto = products.Select(p => new DTOProduct
            {
                Id = p.Id,
                Name = p.Name,
                Value = p.Value
            });

            return dto;
        }
    }
}