using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.Data.SqlClient;

namespace Application.UseCase.Services
{
    public class OfferCommandService : IOfferCommandService
    {
        private readonly IOfferCommand _command;
        private readonly IMapper _mapper;

        public OfferCommandService(IOfferCommand command, IMapper mapper)
        {
            _command = command;
            _mapper = mapper;
        }

        public async Task<OfferResponse> Create(OfferRequest request)
        {
            try
            {
                var offer = _mapper.Map<Offer>(request);
                offer.Status = true;
                offer.OfferId = Guid.NewGuid();

                request.Categories.ForEach(c =>
                {
                    offer.OfferCategories.Add(new OfferCategory
                    {
                        OfferId = offer.OfferId,
                        CategoryId = c
                    });
                });

                request.Skills.ForEach(sk =>
                {
                    offer.OfferSkills.Add(new OfferSkill
                    {
                        OfferId = offer.OfferId,
                        SkillId = sk
                    });
                });

                offer = await _command.Insert(offer);

                var response = _mapper.Map<OfferResponse>(offer);
                response.Ubication = new UbicationResponse
                {
                    Province = offer.City.Province.Name,
                    City = offer.City.Name
                };
                offer.OfferCategories.ForEach(c =>
                {
                    response.Categories.Add(_mapper.Map<CategoryResponse>(c));
                });
                offer.OfferSkills.ForEach(sk => 
                {
                    response.Skills.Add(_mapper.Map<SkillResponse>(sk));
                });
                return response;
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    throw;
                }
                if (e.InnerException is SqlException sqlException)
                {
                    if (sqlException.Number == 547) // / Se comprueba si hay una violación de clave externa
                    {
                        throw new ConflictException("Verifique la información ingresada, el ID del User y de City deben estar presentes.");
                    }
                    if (sqlException.Number == 2601) // / Se comprueba si hay un duplicado
                    {
                        throw new ConflictException("Ya hay una cuenta registrada para el ID asociado.");
                    }
                }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public Task DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<OfferResponse> Update(Guid id, OfferRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
