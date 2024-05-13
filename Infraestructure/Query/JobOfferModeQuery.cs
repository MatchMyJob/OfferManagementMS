﻿using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class JobOfferModeQuery : IJobOfferModeQuery
    {

        private readonly AppDbContext _context;

        public JobOfferModeQuery(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<JobOfferModes>> RecoveryAll()
        {
            List<JobOfferModes> jobOfferMode = await _context.JobOfferMode
                .ToListAsync();
            return jobOfferMode;
        }

        public Task<Paged<JobOfferModes>> RecoveryAll(Parameters parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<JobOfferModes> RecoveryById(int id)
        {
            var jobOfferMode = await _context.JobOfferMode
                .FirstOrDefaultAsync(p => p.JobOfferModeId == id);

            if (jobOfferMode == null)
            {
                throw new NotFoundException("La JobOfferMode con el ID " + id + " no fue encontrada.");
            }

            return jobOfferMode;
        }


    }
}
