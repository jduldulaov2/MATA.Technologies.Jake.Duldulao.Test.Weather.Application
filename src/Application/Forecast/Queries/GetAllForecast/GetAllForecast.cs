using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Queries.GetAllForecast;

public record GetAllForecastQuery : IRequest<List<GetAllForecastQueryDto>>
{

}

public class GetAllForecastQueryHandler : IRequestHandler<GetAllForecastQuery, List<GetAllForecastQueryDto>>
{
    private readonly IApplicationDbContext _context;

    public GetAllForecastQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<GetAllForecastQueryDto>> Handle(GetAllForecastQuery request, CancellationToken cancellationToken)
    {
        return await _context.Forecast
                 .OrderByDescending(f => f.ForecastDate)
                 .Select(forecast => new GetAllForecastQueryDto
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
                 .ToListAsync();
    }
}
