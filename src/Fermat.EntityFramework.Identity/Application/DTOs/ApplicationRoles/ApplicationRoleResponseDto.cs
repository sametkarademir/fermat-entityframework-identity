using Fermat.Domain.Shared.DTOs;

namespace Fermat.EntityFramework.Identity.Application.DTOs.ApplicationRoles;

public class ApplicationRoleResponseDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string ConcurrencyStamp { get; set; } = null!;
}