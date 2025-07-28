using Fermat.Domain.Shared.Filters;
using Fermat.Domain.Shared.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Fermat.EntityFramework.Identity.Domain.Entities;

public class ApplicationRoleClaim : IdentityRoleClaim<Guid>, ICreationAuditedObject, IEntity
{
    [ExcludeFromProcessing]
    public DateTime CreationTime { get; set; }
    [ExcludeFromProcessing]
    public Guid? CreatorId { get; set; }

    public ApplicationRole? Role { get; set; }
}