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
        private readonly ICategoryQuery _categoryQuery;
        private readonly ISkillQuery _skillQuery;
        private readonly IMapper _mapper;

        public OfferCommandService(IOfferCommand command, IMapper mapper, ICategoryQuery categoryQuery, ISkillQuery skillQuery)
        {
            _command = command;
            _mapper = mapper;
            _categoryQuery = categoryQuery;
            _skillQuery = skillQuery;
        }

        public async Task<OfferResponse> Create(OfferRequest request)
        {
            try
            {
                List<OfferCategory> categories = new();
                List<OfferSkill> skills = new();

                await CheckAddCategories(request, categories);
                await CheckAddSkills(request, skills);

                var offer = _mapper.Map<Offer>(request);
                offer.Status = true;
                offer.OfferId = Guid.NewGuid();
                offer.OfferCategories = categories;
                offer.OfferSkills = skills;

                offer = await _command.Insert(offer);

                var response = _mapper.Map<OfferResponse>(offer);
                response.Ubication = new UbicationResponse
                {
                    Province = offer.City.Province.Name,
                    City = offer.City.Name
                };
                offer.OfferCategories.ForEach(c =>
                {
                    response.Categories.Add(_mapper.Map<CategoryResponse>(c.Category));
                });
                offer.OfferSkills.ForEach(sk => 
                {
                    response.Skills.Add(_mapper.Map<SkillResponse>(sk.Skill));
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
                        throw new BadRequestException("Verifique la información ingresada; todos los IDs presentes deben ser válidos y corresponder a registros existentes.");
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

        public async Task<OfferResponse> Update(Guid id, OfferRequest request)
        {
            try
            {
                List<OfferCategory> categories = new();
                List<OfferSkill> skills = new();

                await CheckAddCategories(request, categories);
                await CheckAddSkills(request, skills);

                var offerUpd = _mapper.Map<Offer>(request);
                offerUpd.OfferId = id;
                offerUpd.Status = true;
                offerUpd.OfferCategories = categories;
                offerUpd.OfferSkills = skills;

                offerUpd = await _command.Update(id, offerUpd);

                var response = _mapper.Map<OfferResponse>(offerUpd);
                response.Ubication = new UbicationResponse
                {
                    Province = offerUpd.City.Province.Name,
                    City = offerUpd.City.Name
                };
                offerUpd.OfferCategories.ForEach(c =>
                {
                    response.Categories.Add(_mapper.Map<CategoryResponse>(c.Category));
                });
                offerUpd.OfferSkills.ForEach(sk =>
                {
                    response.Skills.Add(_mapper.Map<SkillResponse>(sk.Skill));
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
                        throw new BadRequestException("Verifique la información ingresada; todos los IDs presentes deben ser válidos y corresponder a registros existentes.");
                    }
                    if (sqlException.Number == 2601) // / Se comprueba si hay un duplicado
                    {
                        throw new ConflictException("Ya hay una cuenta registrada para el ID asociado.");
                    }
                }
                throw new InternalServerErrorException(e.Message);
            }
        }


        private async Task CheckAddCategories(OfferRequest request, List<OfferCategory> categories)
        {
            foreach (int id in request.Categories)
            {
                await _categoryQuery.RecoveryById(id); //Si no existe, este metodo lanza exception
                categories.Add(new OfferCategory
                {
                    CategoryId = id,
                });
            }
        }

        private async Task CheckAddSkills(OfferRequest request, List<OfferSkill> skills)
        {
            foreach (int id in request.Skills)
            {
                await _skillQuery.RecoveryById(id); //Si no existe, este metodo lanza exception
                skills.Add(new OfferSkill
                {
                    SkillId = id
                });
            }
        }
    }
}
