using Application.DTO.Request;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IApplicationCommand : ICommand<Domain.Entities.Aplication, int>
    {


    }
}
