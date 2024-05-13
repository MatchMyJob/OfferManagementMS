using Application.DTO.Error;
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
            CreateMap<ApplicationResponse, Aplication>().ReverseMap();
            CreateMap<CategoryResponse, Category>().ReverseMap();
            CreateMap<JobOfferModeResponse, JobOfferMode>().ReverseMap();
            CreateMap<OfferResponse, Offer>().ReverseMap();
            CreateMap<SkillResponse, Skill>().ReverseMap();
            CreateMap<StudyTypeResponse, StudyType>().ReverseMap();

            CreateMap<Province, ProvincesResponse>().ReverseMap();
            CreateMap<City, CityResponse>().ReverseMap();

            CreateMap<HTTPError, HTTPResponse<string>>().ReverseMap();
        }
    }
}
