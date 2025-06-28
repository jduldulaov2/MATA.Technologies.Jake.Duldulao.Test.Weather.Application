using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Commands.ExternalLogin;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models.Enums;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Command.CreateForecast;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using static System.Net.WebRequestMethods;


public record ExchangeCodeCommand : IRequest<Result<ExchangeCodeRequest>>
{
    public string? Code { get; init; }
}

public class ExchangeCodeCommandHandler : IRequestHandler<ExchangeCodeCommand, Result<ExchangeCodeRequest>>
{
    private readonly IIdentityService _identityService;
    private readonly HttpClient _http;
    private readonly IConfiguration _config;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ExchangeCodeCommandHandler(IIdentityService identityService, IConfiguration config, IHttpContextAccessor httpContextAccessor)
    {
        _identityService = identityService;
        _http = new HttpClient();
        _config = config;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<Result<ExchangeCodeRequest>> Handle(ExchangeCodeCommand request, CancellationToken cancellationToken)
    {
        if (request == null || string.IsNullOrEmpty(request.Code))
            return new()
            {
                Data = new ExchangeCodeRequest
                {
                   
                },
                Message = "failed",
                ResultType = ResultType.Success,
            };

        var clientSecret = _config["GitSettings:ClientSecret"];
        var clientId = _config["GitSettings:ClientId"];
        var redirectUrl = _config["GitSettings:RedirectUri"];
        var authAccessTokenUrl = _config["GitSettings:AuthAccessTokenUrl"];
        var reponseAPI = _config["GitSettings:ReponseAPI"];
        var urls = GetBaseUrl();

        var response = await _http.PostAsync(
            authAccessTokenUrl,
            new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["client_id"] = clientId ?? "",
                ["client_secret"] = clientSecret ?? "",
                ["code"] = request.Code,
                ["redirect_uri"] = GetBaseUrl() + redirectUrl ?? ""
            }));

        var body = await response.Content.ReadAsStringAsync();
        var query = System.Web.HttpUtility.ParseQueryString(body);
        var accessToken = query["access_token"];

        _http.DefaultRequestHeaders.UserAgent.ParseAdd("MATA.Technologies.Jake.Duldulao.Test.Weather.Application");
        _http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
        _http.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/vnd.github+json"));

        var response_api = await _http.GetAsync(reponseAPI);

        var json = await response_api.Content.ReadAsStringAsync();

        var gitHubUser = JsonSerializer.Deserialize<ExchangeCodeRequest>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return new()
        {
            Data = new ExchangeCodeRequest
            {
                login = gitHubUser?.login ?? "",
                name = gitHubUser?.name ?? "",
                email = gitHubUser?.email ?? "",
                avatar_url = gitHubUser?.avatar_url ?? "",
                html_url = gitHubUser?.html_url ?? "",
                access_token = accessToken ?? ""
            },
            Message = "success",
            ResultType = ResultType.Success,
        };

    }

    public string? GetBaseUrl()
    {
        var request = _httpContextAccessor?.HttpContext?.Request;
        if (request == null)
        {
            // You can log or handle this gracefully depending on your use case
            return null;
        }

        return $"{request.Scheme}://{request.Host}";
    }
}
