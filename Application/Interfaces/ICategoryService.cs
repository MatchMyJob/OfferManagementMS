﻿using Application.DTO.Pagination;

namespace Application.Interfaces
{
    public interface ICategoryService<Request, Response> where Request : class where Response : class
    {
        Task<Response> Create(Request request);
        Task DeleteById(int id);
        Task<Paged<Response>> GetAll(int pageNumber, int pageSize);
        Task<Response> GetById(int id);
        Task<Response> Update(int id, Request request);
    }
}
