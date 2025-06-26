using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Commands.Logout;
public record LogoutCommand : IRequest<Result<LogoutDto>>
{
    public string? UserId { get; init; }
}

public class LogoutCommandHandler : IRequestHandler<LogoutCommand, Result<LogoutDto>>
{
    private readonly IIdentityService _identityService;

    public LogoutCommandHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    public async Task<Result<LogoutDto>> Handle(LogoutCommand request, CancellationToken cancellationToken)
    {
        return await _identityService.LogOut(request.UserId);
    }
}
