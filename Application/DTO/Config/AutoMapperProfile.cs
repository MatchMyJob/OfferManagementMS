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
            CreateMap<CategoryResponse, Category>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CategoryId));
            CreateMap<JobOfferModeResponse, JobOfferMode>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.JobOfferModeId));
            CreateMap<OfferResponse, Offer>().ReverseMap();
            CreateMap<SkillResponse, Skill>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.SkillId));
            CreateMap<StudyTypeResponse, StudyType>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.StudyTypeId));

            CreateMap<Province, ProvincesResponse>().ReverseMap();
            CreateMap<City, CityResponse>().ReverseMap();

            CreateMap<HTTPError, HTTPResponse<string>>().ReverseMap();
        }
    }
}
