using Api.Data.Entities;
using AutoMapper;

namespace Api.XEnterprise.Mappers
{
    public class MapperProfiles: Profile
    {
        public MapperProfiles()
        {
            CreateMap<PermissionDto, Permission>()
                .ReverseMap();

            CreateMap<PermissionTypeDto, PermissionType>()
                .ReverseMap();
                //.ForMember(dto => dto.Permissions, cfg=> cfg.Ignore());
        }
    }
}
