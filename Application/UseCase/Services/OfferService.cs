using Application.Interfaces;
using AutoMapper;
using Application.DTO.Error;
using Microsoft.EntityFrameworkCore;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.DTO.Request;

namespace Application.UseCase.Services
{
    public class OfferService : IOfferService
    {
        protected readonly IOfferRepository _repository;
        protected readonly IMapper _mapper;
        protected readonly IOfferQuery _query;
        public Parameters parameters;

        public OfferService(IOfferRepository repository, IOfferQuery query, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _query = query;
            parameters = new();
        }
        public async Task<OfferResponse> Create(OfferRequest request)
        {
            try
            {
                T entity = _mapper.Map<T>(request);
                entity = await _repository.Insert(entity);
                return _mapper.Map<OfferResponse>(entity);
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

        public async Task<Paged<OfferResponse>> GetAll(int pagedNumber, int pagedSize)
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

                Paged<T> list = await _repository.RecoveryAll(parameters);
                List<OfferResponse> listAux = new();
                list.Data.ForEach(e => listAux.Add(_mapper.Map<OfferResponse>(e)));

                return new Paged<OfferResponse>(listAux, list.MetaData.TotalCount, parameters.PageNumber, parameters.PageSize);
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

        public async Task<OfferResponse> GetById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new BadRequestException("The ID must be greater than zero.");
                }

                var entity = await _query.RecoveryById(id);
                if (entity == null)
                {
                    throw new NotFoundException("The record with ID " + id + " was not found.");
                }
                return _mapper.Map<OfferResponse>(entity);
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

        public virtual Task<OfferResponse> Update(int id, Request request)
        {
            throw new NotImplementedException();
        }
    }
}
