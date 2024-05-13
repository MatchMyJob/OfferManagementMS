using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using AutoMapper;
using Domain.Entities;

namespace Application.DTO.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<OBJETO_QUE_SALE, OBJETO_QUE_ENTRA>().ReverseMap();
            CreateMap<ApplicationResponse, Applications>().ReverseMap();
            CreateMap<CategoryResponse, Categories>().ReverseMap();
            CreateMap<JobOfferModeResponse, JobOfferModes>().ReverseMap();
            CreateMap<OfferResponse, Offers>().ReverseMap();
            CreateMap<SkillResponse, Skills>().ReverseMap();
            CreateMap<StudyTypeResponse, StudyTypes>().ReverseMap();

            CreateMap<Provinces, ProvincesResponse>().ReverseMap();
            CreateMap<Cities, CityResponse>().ReverseMap();

            CreateMap<HTTPError, HTTPResponse<string>>().ReverseMap();
        }
    }
}
