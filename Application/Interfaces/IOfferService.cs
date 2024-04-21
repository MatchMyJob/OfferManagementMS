using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IOfferService
    {
        Task<OfferResponse> Create(OfferRequest request);
        Task DeleteById(int id);
        Task<Paged<OfferResponse>> GetAll(int pageNumber, int pageSize);
        Task<OfferResponse> GetById(int id);
      //  Task<OfferResponse> Update(int id, OfferRequest request);
    }
}
