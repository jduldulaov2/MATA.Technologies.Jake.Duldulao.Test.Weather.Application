using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
