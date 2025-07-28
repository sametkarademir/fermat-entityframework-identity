using AutoMapper;
using Fermat.Domain.Exceptions.Types;
using Fermat.EntityFramework.Identity.Application.DTOs.ApplicationUserProfiles;
using Fermat.EntityFramework.Identity.Domain.Entities;
using Fermat.EntityFramework.Identity.Domain.Interfaces.Repositories;
using Fermat.EntityFramework.Identity.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Fermat.EntityFramework.Identity.Application.Services;

public class ApplicationUserProfileAppService(
    UserManager<ApplicationUser> userManager,
    IApplicationUserRepository applicationUserRepository,
    ICurrentUser currentUser,
    IMapper mapper) : IApplicationUserProfileAppService
{
    public async Task<ApplicationUserProfileResponseDto> GetProfileAsync(CancellationToken cancellationToken = default)
    {
        var matchedUser = await applicationUserRepository.GetAsync(
            item => item.Id == currentUser.Id,
            item => item
                .Include(x => x.UserRoles)
                .ThenInclude(x => x.Role!),
            enableTracking: false,
            cancellationToken: cancellationToken);

        var mappedUser = mapper.Map<ApplicationUserProfileResponseDto>(matchedUser);
        mappedUser.Roles = matchedUser.UserRoles.Select(role => role.Role!.Name!).ToList();
        return mappedUser;
    }

    public async Task ChangePasswordAsync(ChangePasswordApplicationUserRequestDto request, CancellationToken cancellationToken = default)
    {
        var matchedUser = await applicationUserRepository.GetAsync(item => item.Id == currentUser.Id, cancellationToken: cancellationToken);
        if (matchedUser.LockoutEnabled && matchedUser.LockoutEnd.HasValue && matchedUser.LockoutEnd.Value > DateTimeOffset.UtcNow)
        {
            var lockoutEnd = matchedUser.LockoutEnd?.ToString("yyyy-MM-dd HH:mm:ss");
            throw new AppBusinessException($"Cannot change password. Account is locked until {lockoutEnd}");
        }

        var result = await userManager.ChangePasswordAsync(matchedUser, request.Password, request.NewPassword);
        if (!result.Succeeded)
        {
            throw new AppUserFriendlyException(string.Join(", ", result.Errors.Select(e => e.Description)));
        }
    }
}