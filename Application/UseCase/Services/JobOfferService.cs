using Application.Interfaces;
using AutoMapper;
using Application.DTO.Error;
using Microsoft.EntityFrameworkCore;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.DTO.Request;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class JobOfferModeService
    { 

        protected readonly IGenericRepository _repository;
        protected readonly IMapper _mapper;
        protected readonly IJobOfferModeQuery _query;
        public Parameters parameters;

        public JobOfferModeService(IGenericRepository repository, IJobOfferModeQuery query, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _query = query;
            parameters = new();
        }
        public async Task<JobOfferModeResponse> Create(JobOfferModeRequest request)
        {
            try
            {
                JobOfferMode entity = _mapper.Map<JobOfferMode>(request);
                entity = await _repository.Insert(entity);
                return _mapper.Map<JobOfferModeResponse>(entity);
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
               /* if (id <= 0)
                {
                    throw new BadRequestException("The ID must be greater than zero.");
                }*/
                var entity = await _query.RecoveryById(id);
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

        public async Task<Paged<JobOfferModeResponse>> GetAll(int pagedNumber, int pagedSize)
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

                Paged<JobOfferMode> list = await _query.RecoveryAll(parameters);
                List<JobOfferModeResponse> listAux = new();
                list.Data.ForEach(e => listAux.Add(_mapper.Map<JobOfferModeResponse>(e)));

                return new Paged<JobOfferModeResponse>(listAux, list.MetaData.TotalCount, parameters.PageNumber, parameters.PageSize);
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

        public async Task<JobOfferModeResponse> GetById(int id)
        {
            try
            {
               /* if (id <= 0)
                {
                    throw new BadRequestException("The ID must be greater than zero.");
                }*/

                var entity = await _query.RecoveryById(id);
                if (entity == null)
                {
                    throw new NotFoundException("The record with ID " + id + " was not found.");
                }
                return _mapper.Map<JobOfferModeResponse>(entity);
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

        public virtual Task<JobOfferModeResponse> Update(int id, Request request)
        {
            throw new NotImplementedException();
        }
    }
}
