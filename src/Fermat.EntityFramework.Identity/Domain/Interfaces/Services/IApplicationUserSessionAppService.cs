using Fermat.EntityFramework.Identity.Application.DTOs.ApplicationUserSessions;
using Fermat.EntityFramework.Shared.DTOs.Pagination;

namespace Fermat.EntityFramework.Identity.Domain.Interfaces.Services;

public interface IApplicationUserSessionAppService
{
    Task<ApplicationUserSessionResponseDto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<PageableResponseDto<ApplicationUserSessionResponseDto>> GetPageableAndFilterAsync(GetListApplicationUserSessionRequestDto request, CancellationToken cancellationToken = default);
}