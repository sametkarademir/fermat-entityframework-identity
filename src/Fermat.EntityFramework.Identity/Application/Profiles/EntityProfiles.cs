using AutoMapper;
using Fermat.EntityFramework.Identity.Application.DTOs.ApplicationRoles;
using Fermat.EntityFramework.Identity.Application.DTOs.ApplicationUsers;
using Fermat.EntityFramework.Identity.Application.DTOs.ApplicationUserSessions;
using Fermat.EntityFramework.Identity.Domain.Entities;

namespace Fermat.EntityFramework.Identity.Application.Profiles;

public class EntityProfiles : Profile
{
    public EntityProfiles()
    {
        CreateMap<ApplicationRole, ApplicationRoleResponseDto>();
        CreateMap<ApplicationUser, ApplicationUserResponseDto>();
        CreateMap<ApplicationUserSession, ApplicationUserSessionResponseDto>();
    }
}