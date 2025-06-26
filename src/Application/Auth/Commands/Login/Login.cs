using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Commands.Login;
public record LoginCommand : IRequest<Result<LoginDto>>
{
    public string? UserName { get; init; }
    public string? Password { get; init; }
    public bool IsPersistent { get; init; }
    public bool LockOutOnFailure { get; init; }

}

public class LoginCommandHandler : IRequestHandler<LoginCommand, Result<LoginDto>>
{
    private readonly IIdentityService _identityService;

    public LoginCommandHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    public async Task<Result<LoginDto>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        return await _identityService.LoginAsync(request.UserName, request.Password, request.IsPersistent, request.LockOutOnFailure);
    }
}
