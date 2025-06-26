using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models.Enums;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Queries.GetForecastByCityAndDate;


public class GetForecastByCityAndDateQuery : IRequest<List<GetForecastByCityAndDateQueryDto>>
{
    public string? City { get; set; }

    public string? ForecastDate { get; set; }
}


public class GetForecastByCityAndDateQueryHandler : IRequestHandler<GetForecastByCityAndDateQuery, List<GetForecastByCityAndDateQueryDto>>
{
    private readonly IApplicationDbContext _context;

    public GetForecastByCityAndDateQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<GetForecastByCityAndDateQueryDto>> Handle(GetForecastByCityAndDateQuery request, CancellationToken cancellationToken)
    {
        return await (from forecast in _context.Forecast
                      where EF.Functions.Like(forecast.City, "%" + request.City + "%")
                      && forecast.ForecastDate == request.ForecastDate
                      select new GetForecastByCityAndDateQueryDto
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
                      }).ToListAsync();

    }
}
