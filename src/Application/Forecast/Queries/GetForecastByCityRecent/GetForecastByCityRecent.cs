using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Queries.GetAllForecast;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Queries.GetForecastByCityRecent;

public record GetForecastByCityRecentQuery : IRequest<List<GetForecastByCityRecentQueryDto>>
{
    public string? City { get; set; }
}

public class GetForecastByCityRecentQueryHandler : IRequestHandler<GetForecastByCityRecentQuery, List<GetForecastByCityRecentQueryDto>>
{
    private readonly IApplicationDbContext _context;

    public GetForecastByCityRecentQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<GetForecastByCityRecentQueryDto>> Handle(GetForecastByCityRecentQuery request, CancellationToken cancellationToken)
    {
        var forecasts = await _context.Forecast.ToListAsync();

        if (!String.IsNullOrEmpty(request.City))
        {
            return forecasts
            .Where(f =>
                !string.IsNullOrWhiteSpace(f.ForecastDate) &&
                DateTime.TryParse(f.ForecastDate, out var parsedDate) &&
                parsedDate <= DateTime.Today
                && f.City == request.City
            )
            .OrderByDescending(f => f.ForecastDate)
            .Select(forecast => new GetForecastByCityRecentQueryDto
            {
                Id = forecast.Id,
                ForecastName = forecast.ForecastName,
                City = forecast.City,
                Temperature = forecast.Temperature,
                ForecastDescription = forecast.ForecastDescription,
                ForecastDate = forecast.ForecastDate,
                ForecastMain = forecast.ForecastMain,
                Pressure = forecast.Pressure,
                Humidity = forecast.Humidity,
                UniqueId = forecast.UniqueId,
                IsActive = forecast.IsActive == null ? true : forecast.IsActive
            })
            .ToList();
        }
        else
        {
            return forecasts
            .Where(f =>
                !string.IsNullOrWhiteSpace(f.ForecastDate) &&
                DateTime.TryParse(f.ForecastDate, out var parsedDate) &&
                parsedDate <= DateTime.Today
            )
            .OrderByDescending(f => f.ForecastDate)
            .Select(forecast => new GetForecastByCityRecentQueryDto
            {
                Id = forecast.Id,
                ForecastName = forecast.ForecastName,
                City = forecast.City,
                Temperature = forecast.Temperature,
                ForecastDescription = forecast.ForecastDescription,
                ForecastDate = forecast.ForecastDate,
                ForecastMain = forecast.ForecastMain,
                Pressure = forecast.Pressure,
                Humidity = forecast.Humidity,
                UniqueId = forecast.UniqueId,
                IsActive = forecast.IsActive == null ? true : forecast.IsActive
            })
            .ToList();
        }
        
    }
}
