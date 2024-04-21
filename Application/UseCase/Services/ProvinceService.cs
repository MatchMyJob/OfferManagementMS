using Application.Interfaces;
using AutoMapper;
using Application.DTO.Error;
using Microsoft.EntityFrameworkCore;
using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.DTO.Response;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class ProvinceService : IProvinceService
    {
        protected readonly IGenericRepository _repository;
        protected readonly IMapper _mapper;
        protected readonly IProvinceQuery _query;
        public Parameters parameters;


        public ProvinceService(IGenericRepository repository, IProvinceQuery query, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _query = query;
            parameters = new();
        }
        public async Task<ProvincesResponse> Create(ProvincesRequest request)
        {
            try
            {
                Provinces entity = _mapper.Map<Provinces>(request);
                entity = await _repository.Insert(entity);
                return _mapper.Map<ProvincesResponse>(entity);
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
                var entity = await _query.GetProvinceById(id);
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

        public async Task<Paged<ProvincesResponse>> GetAll(int pagedNumber, int pagedSize)
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

                List<Provinces> list = await _query.GetAllProvince();
                List<ProvincesResponse> listAux = new();
                //list.Data.ForEach(e => listAux.Add(_mapper.Map<ProvincesResponse>(e)));

                //return new Paged<ProvincesResponse>(listAux, list.MetaData.TotalCount, parameters.PageNumber, parameters.PageSize);
                return new Paged<ProvincesResponse> (listAux, list.Count, parameters.PageNumber,parameters.PageSize);
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

        public async Task<ProvincesResponse> GetById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new BadRequestException("The ID must be greater than zero.");
                }

                var entity = await _query.GetProvinceById(id);
                if (entity == null)
                {
                    throw new NotFoundException("The record with ID " + id + " was not found.");
                }
                return _mapper.Map<ProvincesResponse>(entity);
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

        public virtual Task<ProvincesResponse> Update(int id, Request request)
        {
            throw new NotImplementedException();
        }
    }
}
