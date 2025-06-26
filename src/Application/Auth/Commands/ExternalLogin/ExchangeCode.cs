using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Commands.ExternalLogin;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models.Enums;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Command.CreateForecast;
using static System.Net.WebRequestMethods;


public record ExchangeCodeCommand : IRequest<Result<ExchangeCodeRequest>>
{
    public string? Code { get; init; }

    public string? RedirectUri { get; init; }
}

public class ExchangeCodeCommandHandler : IRequestHandler<ExchangeCodeCommand, Result<ExchangeCodeRequest>>
{
    private readonly IIdentityService _identityService;
    private readonly HttpClient _http;

    public ExchangeCodeCommandHandler(IIdentityService identityService)
    {
        _identityService = identityService;
        _http = new HttpClient();
    }

    public async Task<Result<ExchangeCodeRequest>> Handle(ExchangeCodeCommand request, CancellationToken cancellationToken)
    {
        if (request == null || string.IsNullOrEmpty(request.Code))
            return new()
            {
                Data = new ExchangeCodeRequest
                {
                    Code = "",
                    RedirectUri = "",
                },
                Message = "failed",
                ResultType = ResultType.Success,
            };

        if (request == null || string.IsNullOrEmpty(request.RedirectUri))
            return new()
            {
                Data = new ExchangeCodeRequest
                {
                    Code = "",
                    RedirectUri = "",
                },
                Message = "failed",
                ResultType = ResultType.Success,
            };

        var clientId = "Ov23liaWF3wQPaLy03zB";
        var clientSecret = "e14635370d4f231bd3738edd6a4d15a658639f5b";

        var response = await _http.PostAsync(
            "https://github.com/login/oauth/access_token",
            new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["client_id"] = clientId,
                ["client_secret"] = clientSecret,
                ["code"] = request.Code,
                ["redirect_uri"] = request.RedirectUri
            }));

        var body = await response.Content.ReadAsStringAsync();
        var query = System.Web.HttpUtility.ParseQueryString(body);
        var accessToken = query["access_token"];

        return new()
        {
            Data = new ExchangeCodeRequest
            {
                Code = "",
                RedirectUri = "",
            },
            Message = "success",
            ResultType = ResultType.Success,
        };

    }
}
