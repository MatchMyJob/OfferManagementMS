﻿using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Azure.Core;
using Domain.Entities;
using Microsoft.Data.SqlClient;

namespace Application.UseCase.Services
{
    public class ApplicationCommandService : IApplicationCommandService
    {
        private readonly IApplicationCommand _command;
        private readonly ICompanyApi _companyApi;
        private readonly IApplicantApi _applicantApi;
        private readonly IMapper _mapper;

        public ApplicationCommandService(IApplicationCommand command, IMapper mapper, ICompanyApi companyApi, IApplicantApi applicantApi)
        {
            _command = command;
            _companyApi = companyApi;
            _applicantApi = applicantApi;
            _mapper = mapper;
        }

        public async Task<ApplicationCandidateResponse> Create(ApplicationRequest request)
        {
            try
            {
                var application = _mapper.Map<Aplication>(request);
                application = await _command.Insert(application);

                var response = _mapper.Map<ApplicationCandidateResponse>(application);

                var apiResponse = await _companyApi.GetById<HTTPResponse<CompanyGetResponse>>(application.Offer.CompanyId, "");
                response.Company = apiResponse.Result;

                return response;
            }
            catch (Exception e)
            {
                if (e is HTTPError) { throw; }
                if (e.InnerException is SqlException sqlException)
                {
                    if (sqlException.Number == 547) // / Se comprueba si hay una violación de clave externa
                    {
                        throw new BadRequestException("Verifique la información ingresada; el ID debe ser válido y corresponder a una oferta existente.");
                    }
                    if (sqlException.Number == 2601) // / Se comprueba si hay un duplicado
                    {
                        throw new ConflictException("El usuario ha aplicado a la oferta anteriormente.");
                    }
                }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task DeleteById(int id)
        {
            try
            {
                if (id < 0) { throw new BadRequestException("El ID debe ser mayor a cero."); }
                await _command.Remove(id);
            }
            catch (Exception e)
            {
                if (e is HTTPError) { throw; }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public Task<ApplicationCandidateResponse> Update(int id, ApplicationUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationUpdateResponse> UpdateApplication(int id, ApplicationUpdateRequest request)
        {
            try
            {
                if (id < 0) { throw new BadRequestException("El ID debe ser mayor a cero."); }

                var application = _mapper.Map<Aplication>(request);
                application = await _command.Update(id, application);

                var response = _mapper.Map<ApplicationUpdateResponse>(application);

                var apiResponse = await _applicantApi.GetById<HTTPResponse<ApplicantResponse>>(application.UserId, "");
                response.Applicant = apiResponse.Result;

                return response;
            }
            catch (Exception e)
            {
                if (e is HTTPError) { throw; }
                if (e.InnerException is SqlException sqlException)
                {
                    if (sqlException.Number == 547) // / Se comprueba si hay una violación de clave externa
                    {
                        throw new BadRequestException("Verifique la información ingresada; el ID presente debe ser válido y corresponder a registros existentes.");
                    }
                }
                throw new InternalServerErrorException(e.Message);
            }
        }
    }
}
