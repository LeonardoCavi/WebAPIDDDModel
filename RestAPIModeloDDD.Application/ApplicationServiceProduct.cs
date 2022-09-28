using RestAPIDDDModel.Application.DTOs;
using RestAPIDDDModel.Application.Interfaces;
using RestAPIDDDModel.Application.Interfaces.Mappers;
using RestAPIDDDModel.Domain.Core.Intefaces.Services;

namespace RestAPIDDDModel.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapperProduct mapperProduct;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapperProduct mapperProduct)
        {
            this.serviceProduct = serviceProduct;
            this.mapperProduct = mapperProduct;
        }

        public void Add(DTOProduct dtoProduct)
        {
            var product = mapperProduct.MapperDtoToEntity(dtoProduct);
            serviceProduct.Add(product);
        }

        public IEnumerable<DTOProduct> GetAll()
        {
            var products = serviceProduct.GetAll();
            return mapperProduct.MapperListDTOClients(products);
        }

        public DTOProduct? GetById(int id)
        {
            var product = serviceProduct.GetById(id);
            return mapperProduct.MapperEntityToDto(product);
        }

        public void Remove(DTOProduct dtoProduct)
        {
            var product = mapperProduct.MapperDtoToEntity(dtoProduct);
            serviceProduct.Remove(product);
        }

        public void Update(DTOProduct dtoProduct)
        {
            var product = mapperProduct.MapperDtoToEntity(dtoProduct);
            serviceProduct.Update(product);
        }
    }
}