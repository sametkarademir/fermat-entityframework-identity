using Fermat.EntityFramework.Identity.Application.DTOs.ApplicationUserProfiles;
using Fermat.EntityFramework.Identity.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fermat.EntityFramework.Identity.Presentation.Controllers;

[ApiController]
[Route("api/user-profile")]
public class UserProfileController(
    IApplicationUserProfileAppService applicationUserProfileAppService) 
    : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(ApplicationUserProfileResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> GetProfileAsync(CancellationToken cancellationToken = default)
    {
        var result = await applicationUserProfileAppService.GetProfileAsync(cancellationToken);
        return Ok(result);
    }
    
    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> ChangePasswordAsync([FromBody] ChangePasswordApplicationUserRequestDto request, CancellationToken cancellationToken = default)
    {
        await applicationUserProfileAppService.ChangePasswordAsync(request, cancellationToken);
        return NoContent();
    }
}