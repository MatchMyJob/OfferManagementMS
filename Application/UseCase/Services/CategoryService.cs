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
    public class CategoryService : ICategoryService
    {
        protected readonly IGenericRepository _repository;
        protected readonly ICategoryQuery _query;
        protected readonly IMapper _mapper;
        public Parameters parameters;

        public CategoryService(IGenericRepository repository, IMapper mapper, ICategoryQuery query)
        {
            _repository = repository;
            _mapper = mapper;
            parameters = new();
            _query = query;
        }
        public async Task<CategoryResponse> Create(CategoryRequest request)
        {
            try
            {
                Categories category = _mapper.Map<Categories>(request);
                var entity = await _repository.Insert(category);
                return _mapper.Map<CategoryResponse>(entity);
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

        
        public async Task<Paged<CategoryResponse>> GetAll(int pagedNumber, int pagedSize)
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

                Paged<Categories> list = await _query.RecoveryAll(parameters);
                List<CategoryResponse> listAux = new();
                list.Data.ForEach(e => listAux.Add(_mapper.Map<CategoryResponse>(e)));

                return new Paged<CategoryResponse>(listAux, list.MetaData.TotalCount, parameters.PageNumber, parameters.PageSize);
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
        
        public async Task<CategoryResponse> GetById(int id)
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
                return _mapper.Map<CategoryResponse>(entity);
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
        

        public virtual Task<CategoryResponse> Update(int id, Request request)
        {
            throw new NotImplementedException();
        }
    }
}
