using Fermat.Domain.Shared.Filters;
using Fermat.Domain.Shared.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Fermat.EntityFramework.Identity.Domain.Entities;

public class ApplicationRole : IdentityRole<Guid>, IFullAuditedObject, IEntity
{
    public string? Description { get; set; }

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

    public ICollection<ApplicationUserRole> UserRoles { get; set; } = [];

    public ApplicationRole()
    {
        ConcurrencyStamp = Guid.NewGuid().ToString("N");
    }

    public ApplicationRole(string roleName) : base(roleName)
    {
        ConcurrencyStamp = Guid.NewGuid().ToString("N");
    }

    public ApplicationRole(string roleName, string? description) : base(roleName)
    {
        ConcurrencyStamp = Guid.NewGuid().ToString("N");
        Description = description;
    }
}