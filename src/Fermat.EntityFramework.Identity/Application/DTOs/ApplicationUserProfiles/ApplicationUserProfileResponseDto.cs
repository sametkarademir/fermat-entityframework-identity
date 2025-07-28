using Fermat.Domain.Shared.DTOs;

namespace Fermat.EntityFramework.Identity.Application.DTOs.ApplicationUserProfiles;

public class ApplicationUserProfileResponseDto : EntityDto<Guid>
{
    public string UserName { get; set; } = null!;
    public string Email { get; set; } = null!;
    
    public bool EmailConfirmed { get; set; }
    public bool PhoneNumberConfirmed { get; set; }
    public bool TwoFactorEnabled { get; set; }
    
    public DateTime? PasswordChangedTime { get; set; }
    
    public List<string> Roles { get; set; } = [];
}