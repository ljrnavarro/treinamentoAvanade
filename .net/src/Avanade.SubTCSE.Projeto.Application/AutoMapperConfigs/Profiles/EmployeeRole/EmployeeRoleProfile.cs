﻿using AutoMapper;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
            CreateMap<Dtos.EmployeeRole.EmployeeRoleDto,
                Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("rolename", opt => opt.MapFrom(src => src.Cargo));

            CreateMap<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole,
                Dtos.EmployeeRole.EmployeeRoleDto>()
                .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.RoleName));
        }
    }
}
