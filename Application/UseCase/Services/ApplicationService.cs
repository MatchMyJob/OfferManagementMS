using Application.Interfaces;
using AutoMapper;
using Application.DTO.Error;
using Microsoft.EntityFrameworkCore;
using Application.DTO.Pagination;
using Domain.Entities;
using Application.DTO.Request;
using Application.DTO.Response;
using Microsoft.Data.SqlClient;

namespace Application.UseCase.Services
{
    public class ApplicationService : IApplicationService
    {
        protected readonly IGenericRepository _repository;
        protected readonly IApplicationQuery _applicationQuery;
        protected readonly IMapper _mapper;
        public Parameters parameters;

        public ApplicationService(IGenericRepository repository, IMapper mapper, IApplicationQuery applicationQuery)
        {
            _repository = repository;
            _mapper = mapper;
            parameters = new();
            _applicationQuery = applicationQuery;
        }
        public async Task<ApplicationResponse> Create(ApplicationRequest request)
        {
            try
            {
                Domain.Entities.Aplication entity = _mapper.Map<Domain.Entities.Aplication>(request);
                entity = await _repository.Insert(entity);
                return _mapper.Map<ApplicationResponse>(entity);
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    throw e;
                }
                if (e is DbUpdateException)
                {
                    throw new ConflictException("There is a record with the same identifier.");
                }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task DeleteById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new BadRequestException("The ID must be greater than zero.");
                }

                var entity = await _applicationQuery.RecoveryById(id);
                if (entity != null)
                {
                    await _repository.Remove(entity);
                    await _repository.SaveChanges();
                }
                else
                {
                    throw new NotFoundException("The record with ID " + id + " was not found.");
                }
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    throw e;
                }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task<Paged<ApplicationResponse>> GetAll(int pagedNumber, int pagedSize)
        {
            try
            {
                if (pagedNumber>=0 && pagedSize>=0)
                {
                    parameters.PageSize = pagedSize;
                    parameters.PageNumber = pagedNumber;
                } else
                {
                    throw new BadRequestException("Ingrese valores válidos para pagedNumber y pagedSize.");
                }

                Paged<Domain.Entities.Aplication> list = await _applicationQuery.RecoveryAll(parameters);
                List<ApplicationResponse> listAux = new();
                list.Data.ForEach(e => listAux.Add(_mapper.Map<ApplicationResponse>(e)));

                return new Paged<ApplicationResponse>(listAux, list.MetaData.TotalCount, parameters.PageNumber, parameters.PageSize);
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    throw e;
                }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task<ApplicationResponse> GetById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new BadRequestException("The ID must be greater than zero.");
                }

                var entity = await _applicationQuery.RecoveryById(id);
                if (entity == null)
                {
                    throw new NotFoundException("The record with ID " + id + " was not found.");
                }
                return _mapper.Map<ApplicationResponse>(entity);
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    throw e;
                }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task<ApplicationResponse> Update(int id, ApplicationRequest request)
        {
            try
            {
                /*
                if (!DateTime.TryParse(request.BirthDate, out _))
                {
                    throw new BadRequestException("Ingrese correctamente la fecha de nacimiento.");
                }
                if (!IsValidPhone(request.Phone.ToString()))
                {
                    throw new BadRequestException("Ingrese un formato valido: '54-1141462757' ");

                }
                if (!IsValidDNI(request.Dni.ToString()))
                {
                    throw new BadRequestException("Ingrese un número de DNI valido: '41539440'");
                }
                */

                var application = _mapper.Map<Domain.Entities.Aplication>(request);
                application = await _repository.Update(application);

                //HARDCORE - ACA LE TENES QUE UPDATEAR LOS DATOS O EN EL GENERIC ? PORQUE NO ES GENERIC EL UPDATE....

                var response = _mapper.Map<ApplicationResponse>(application);
                /*response.Ubication = new UbicationResponse
                {
                    City = applicant.CityObject.Name,
                    Province = applicant.CityObject.ProvinceObject.Name
                };*/
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
                        throw new ConflictException("Verifique la información a actualizar, la city no existe.");
                    }
                    if (sqlException.Number == 2601) // / Se comprueba si hay un duplicado
                    {
                        throw new ConflictException("Ya se encuentra el DNI.");
                    }
                }
                throw new InternalServerErrorException(e.Message);
            }
        }
    }
}
