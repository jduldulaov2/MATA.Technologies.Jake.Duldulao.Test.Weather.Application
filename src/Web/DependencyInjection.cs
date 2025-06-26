using Azure.Identity;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Infrastructure.Data;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Infrastructure.Helpers;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Web.Services;
using Microsoft.AspNetCore.Mvc;


namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddWebServices(this IServiceCollection services)
    {
        services.AddDatabaseDeveloperPageExceptionFilter();

        services.AddScoped<IUser, CurrentUser>();

        services.AddScoped<IJsonService, JsonService>();

        services.AddScoped<IEmailService, EmailService>();

        services.AddScoped<IPassword, Password>();

        services.AddHttpContextAccessor();

        services.AddHealthChecks()
            .AddDbContextCheck<ApplicationDbContext>();

        services.AddExceptionHandler<CustomExceptionHandler>();

        services.AddRazorPages();

        // Customise default API behaviour
        services.Configure<ApiBehaviorOptions>(options =>
            options.SuppressModelStateInvalidFilter = true);

        services.AddEndpointsApiExplorer();

        services.AddOpenApiDocument((configure, sp) =>
        {
            configure.Title = "MATA.Technologies.Jake.Duldulao.Test.Weather.Application API";

        });

        return services;
    }

    public static IServiceCollection AddKeyVaultIfConfigured(this IServiceCollection services, ConfigurationManager configuration)
    {
        var keyVaultUri = configuration["KeyVaultUri"];
        if (!string.IsNullOrWhiteSpace(keyVaultUri))
        {
            configuration.AddAzureKeyVault(
                new Uri(keyVaultUri),
                new DefaultAzureCredential());
        }

        return services;
    }
}
