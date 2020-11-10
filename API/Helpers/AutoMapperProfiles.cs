using AutoMapper;
using API.Entities;
using API.DTOs;
using System.Linq;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
            .ForMember(
                dest => dest.PhotoUrl,
                opt => opt.MapFrom(
                    src => src.Photos.FirstOrDefault(x => x.IsMain).Url
                    )
                );
            CreateMap<Photo, PhotoDto>();
        }
    }
}