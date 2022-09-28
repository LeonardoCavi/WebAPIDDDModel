using RestAPIDDDModel.Application.DTOs;

namespace RestAPIDDDModel.Application.Interfaces
{
    public interface IApplicationServiceProduct
    {
        void Add(DTOProduct dtoProduct);

        void Update(DTOProduct dtoProduct);

        void Remove(DTOProduct dtoProduct);

        IEnumerable<DTOProduct> GetAll();

        DTOProduct? GetById(int id);
    }
}