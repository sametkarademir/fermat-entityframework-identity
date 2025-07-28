using Fermat.Domain.Shared.Filters;
using Fermat.Domain.Shared.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Fermat.EntityFramework.Identity.Domain.Entities;

public class ApplicationUserRole : IdentityUserRole<Guid>, IFullAuditedObject, IEntity
{
    [ExcludeFromProcessing]
    public DateTime CreationTime { get; set; }
    [ExcludeFromProcessing]
    public Guid? CreatorId { get; set; }
    [ExcludeFromProcessing]
    public DateTime? LastModificationTime { get; set; }
    [ExcludeFromProcessing]
    public Guid? LastModifierId { get; set; }
    [ExcludeFromProcessing]
    public DateTime? DeletionTime { get; set; }
    [ExcludeFromProcessing]
    public Guid? DeleterId { get; set; }
    [ExcludeFromProcessing]
    public bool IsDeleted { get; set; }

    public ApplicationUser? User { get; set; }
    public ApplicationRole? Role { get; set; }

    public ApplicationUserRole()
    {

    }

    public ApplicationUserRole(Guid userId, Guid roleId)
    {
        UserId = userId;
        RoleId = roleId;
    }
}