using Fermat.EntityFramework.Identity.Application.DTOs.ApplicationUserProfiles;

namespace Fermat.EntityFramework.Identity.Domain.Interfaces.Services;

public interface IApplicationUserProfileAppService
{
    Task<ApplicationUserProfileResponseDto> GetProfileAsync(CancellationToken cancellationToken = default);
    Task ChangePasswordAsync(ChangePasswordApplicationUserRequestDto request, CancellationToken cancellationToken = default);
}