using AutoMapper;
using Fligoo.Challenge.Data.Entities;
using Fligoo.Challenge.Services.Models.ExternalProviders;
using System;

namespace Fligoo.Challenge.Services.Extensions
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Competition, CompetitionResponse>();
            CreateMap<CompetitionResponse, Competition>()
                .ForMember(dest => dest.Plan, act => act.MapFrom(src => src.Plan != null ? src.Plan : string.Empty))
                .ForMember(dest => dest.LastUpdated, act => act.MapFrom(src => src.LastUpdated == DateTime.MinValue ? DateTime.Now : src.LastUpdated));
        }
    }
}
