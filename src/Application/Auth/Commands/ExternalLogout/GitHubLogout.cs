using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models.Enums;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Command.CreateForecast;
using Microsoft.Extensions.Configuration;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Commands.ExternalLogout;

public record GitHubLogoutCommand : IRequest<Result<GitHubLogoutDto>>
{
    public string? AccessToken { get; init; }

}

public class GitHubLogoutCommandHandler : IRequestHandler<GitHubLogoutCommand, Result<GitHubLogoutDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IConfiguration _config;

    public GitHubLogoutCommandHandler(IApplicationDbContext context, IConfiguration config)
    {
        _context = context;
        _config = config;
    }

    public async Task<Result<GitHubLogoutDto>> Handle(GitHubLogoutCommand request, CancellationToken cancellationToken)
    {
        var httpClient = new HttpClient();
        var clientSecret = _config["GitSettings:ClientSecret"];
        var clientId = _config["GitSettings:ClientId"];

        // Set GitHub API headers
        httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("MATA.Technologies.Jake.Duldulao.Test.Weather.Application", "1.0")); // GitHub requires a user agent
        var credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}"));
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

        // Create JSON body
        var body = new StringContent($"{{ \"access_token\": \"{request.AccessToken}\" }}", Encoding.UTF8, "application/json");

        // Create request message
        var request_revoke = new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = new Uri($"https://api.github.com/applications/{clientId}/grant"),
            Content = body
        };

        // Send request
        var response = await httpClient.SendAsync(request_revoke);

        string requestMessage = "";

        // Check if the request was successful
        if (response.IsSuccessStatusCode)
        {
            requestMessage = "Token revoked successfully.";
        }
        else
        {
            requestMessage = "Failed to revoke token.";
        }

        return new()
        {
            Data = new GitHubLogoutDto
            {
                Message = requestMessage,
            },
            Message = "Succcessfully revoke",
            ResultType = response.IsSuccessStatusCode ? ResultType.Success : ResultType.Error
    };
    }
}

