using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class ApplicationQueryService : IApplicationQueryService
    {
        private readonly IApplicationQuery _query;
        private readonly ICompanyApi _api;
        private readonly IMapper _mapper;

        public ApplicationQueryService(IApplicationQuery query, IMapper mapper, ICompanyApi api)
        {
            _query = query;
            _mapper = mapper;
            _api = api;
        }

        public async Task<Paged<ApplicationCandidateResponse>> GetAllPaged(int pageNumber, int pageSize)
        {
            try
            {
                if (pageNumber <= 0 || pageSize <= 0)
                {
                    throw new BadRequestException("Ingrese valores mayores que cero (0) para pageNumber y pageSize.");
                }
                Parameters parameters = new Parameters(pageNumber, pageSize);

                Paged<Aplication> applications = await _query.RecoveryAll(parameters);
                List<ApplicationCandidateResponse> responses = new();

                foreach (var application in applications.Data)
                {
                    var applicationResponse = _mapper.Map<ApplicationCandidateResponse>(application);

                    var apiResponse = await _api.GetById<HTTPResponse<CompanyGetResponse>>(application.Offer.CompanyId, "");
                    applicationResponse.Company = apiResponse.Result;

                    responses.Add(applicationResponse);
                }

                return new Paged<ApplicationCandidateResponse>(responses, applications.MetaData.TotalCount, parameters.PageNumber, pageSize);
            }
            catch (Exception e)
            {
                if (e is HTTPError) { throw; }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task<ApplicationCandidateResponse> GetById(int id)
        {
            try
            {
                var application = await _query.RecoveryById(id);
                var response = _mapper.Map<ApplicationCandidateResponse>(application);

                var apiResponse = await _api.GetById<HTTPResponse<CompanyGetResponse>>(application.Offer.CompanyId, "");
                response.Company = apiResponse.Result;

                return response;
            }
            catch (Exception e)
            {
                if (e is HTTPError) { throw; }
                throw new InternalServerErrorException(e.Message);
            }
        }
    }
}
