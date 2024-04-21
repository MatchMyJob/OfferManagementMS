using Application.DTO.Request;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IApplicationCommand : ICommand<Applications, int>
    {


    }
}
