using System.Security.Claims;

using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Web.Services;

public class CurrentUser : IUser
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUser(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string? Id => _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
}
