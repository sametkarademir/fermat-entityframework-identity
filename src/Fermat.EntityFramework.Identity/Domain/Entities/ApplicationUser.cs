using Fermat.Domain.Shared.Filters;
using Fermat.Domain.Shared.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Fermat.EntityFramework.Identity.Domain.Entities;

public class ApplicationUser : IdentityUser<Guid>, IFullAuditedObject, IEntity
{
    public DateTime? PasswordLastSetTime { get; set; }

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
    public ICollection<ApplicationUserSession> UserSessions { get; set; } = [];

    public ApplicationUser()
    {
        ConcurrencyStamp = Guid.NewGuid().ToString("N");
    }
}