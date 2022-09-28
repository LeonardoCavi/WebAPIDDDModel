using RestAPIDDDModel.Application.DTOs;

namespace RestAPIDDDModel.Application.Interfaces
{
    public interface IApplicationServiceClient
    {
        void Add(DTOClient dtoClient);

        void Update(DTOClient dtoClient);

        void Remove(DTOClient dtoClient);

        IEnumerable<DTOClient> GetAll();

        DTOClient? GetById(int id);
    }
}