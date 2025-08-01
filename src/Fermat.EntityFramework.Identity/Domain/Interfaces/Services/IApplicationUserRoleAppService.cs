using Fermat.EntityFramework.Identity.Application.DTOs.ApplicationRoles;
using Fermat.EntityFramework.Identity.Application.DTOs.ApplicationUsers;

namespace Fermat.EntityFramework.Identity.Domain.Interfaces.Services;

public interface IApplicationUserRoleAppService
{
    Task AssignRoleToUserAsync(Guid userId, Guid roleId, CancellationToken cancellationToken = default);
    Task RemoveRoleFromUserAsync(Guid userId, Guid roleId, CancellationToken cancellationToken = default);
    Task ClearRolesFromUserAsync(Guid userId, CancellationToken cancellationToken = default);

    Task<List<ApplicationRoleResponseDto>> GetRolesByUserIdAsync(Guid userId, CancellationToken cancellationToken = default);
    Task<List<ApplicationUserResponseDto>> GetUsersByRoleIdAsync(Guid roleId, CancellationToken cancellationToken = default);
}