using Fermat.EntityFramework.Identity.Application.DTOs.ApplicationRoles;
using Fermat.EntityFramework.Shared.DTOs.Pagination;

namespace Fermat.EntityFramework.Identity.Domain.Interfaces.Services;

public interface IApplicationRoleAppService
{
    Task<ApplicationRoleResponseDto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<PageableResponseDto<ApplicationRoleResponseDto>> GetPageableAndFilterAsync(GetListApplicationRoleRequestDto request, CancellationToken cancellationToken = default);
    Task<List<ApplicationRoleResponseDto>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<ApplicationRoleResponseDto> CreateAsync(CreateApplicationRoleRequestDto request, CancellationToken cancellationToken = default);
    Task<ApplicationRoleResponseDto> UpdateAsync(Guid id, UpdateApplicationRoleRequestDto request, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}