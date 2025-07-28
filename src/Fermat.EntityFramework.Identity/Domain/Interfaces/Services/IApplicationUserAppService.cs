using Fermat.EntityFramework.Identity.Application.DTOs.ApplicationUsers;
using Fermat.EntityFramework.Shared.DTOs.Pagination;

namespace Fermat.EntityFramework.Identity.Domain.Interfaces.Services;

public interface IApplicationUserAppService
{
    Task<ApplicationUserResponseDto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<PageableResponseDto<ApplicationUserResponseDto>> GetPageableAndFilterAsync(GetListApplicationUserRequestDto request, CancellationToken cancellationToken = default);
    Task<ApplicationUserResponseDto> CreateAsync(CreateApplicationUserRequestDto request, CancellationToken cancellationToken = default);
    Task<ApplicationUserResponseDto> UpdateAsync(Guid id, UpdateApplicationUserRequestDto request, CancellationToken cancellationToken = default);
    Task<ApplicationUserResponseDto> LockAsync(Guid id, bool isPermanent, CancellationToken cancellationToken = default);
    Task<ApplicationUserResponseDto> UnlockAsync(Guid id, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}