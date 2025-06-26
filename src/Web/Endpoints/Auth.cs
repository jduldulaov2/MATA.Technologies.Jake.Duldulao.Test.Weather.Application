using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Commands.ExternalLogin;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Commands.Login;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Commands.Logout;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Queries.GetLoggedIn;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Web.Endpoints;

public class Auth : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(Login, "Login")
            .MapGet(GetGitTokens, "GetGitTokens")
            .MapGet(LogOut, "LogOut")
            .MapGet(GeLoggedIn, "GeLoggedIn")
            ;
    }

    public async Task<Result<LoginDto>> Login(ISender sender, [AsParameters] LoginCommand query)
    {
        return await sender.Send(query);
    }

    public async Task<Result<LogoutDto>> LogOut(ISender sender, [AsParameters] LogoutCommand query)
    {
        return await sender.Send(query);
    }

    public async Task<Result<GetLoggedInQueryDto>> GeLoggedIn(ISender sender, [AsParameters] GetLoggedInQuery query)
    {
        return await sender.Send(query);
    }

    public async Task<Result<ExchangeCodeRequest>> GetGitTokens(ISender sender, [AsParameters] ExchangeCodeCommand query)
    {
        return await sender.Send(query);
    }

}
