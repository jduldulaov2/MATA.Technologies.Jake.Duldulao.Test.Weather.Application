using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Queries.GetLoggedIn;

public record GetLoggedInQuery : IRequest<Result<GetLoggedInQueryDto>>
{

}

public class GetLoggedInQueryHandler : IRequestHandler<GetLoggedInQuery, Result<GetLoggedInQueryDto>>
{
    private readonly IIdentityService _identityService;

    public GetLoggedInQueryHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    public async Task<Result<GetLoggedInQueryDto>> Handle(GetLoggedInQuery request, CancellationToken cancellationToken)
    {
        return await _identityService.GetLoggedIn();
    }
}
