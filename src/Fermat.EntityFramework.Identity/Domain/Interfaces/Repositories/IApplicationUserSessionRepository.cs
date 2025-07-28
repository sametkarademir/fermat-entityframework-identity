using Fermat.EntityFramework.Identity.Domain.Entities;
using Fermat.EntityFramework.Shared.Interfaces;

namespace Fermat.EntityFramework.Identity.Domain.Interfaces.Repositories;

public interface IApplicationUserSessionRepository : IRepository<ApplicationUserSession, Guid>
{

}