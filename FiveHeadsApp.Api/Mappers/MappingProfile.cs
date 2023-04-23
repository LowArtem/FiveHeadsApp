using FiveHeadsApp.Core.Dto;
using FiveHeadsApp.Core.Model.Auth;
using AutoMapper;

namespace FiveHeadsApp.Api.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, ResponseDto>()
            .ForMember(
                dest => dest.RoleIds,
                opt =>
                    opt.MapFrom(u => u.UserRoles.Select(r => r.Id)));
    }
}