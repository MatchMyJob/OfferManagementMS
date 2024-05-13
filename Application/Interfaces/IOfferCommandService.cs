using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IOfferCommandService : ICommandService<OfferRequest, OfferResponse, OfferRequest, Guid>
    {
    }
}
