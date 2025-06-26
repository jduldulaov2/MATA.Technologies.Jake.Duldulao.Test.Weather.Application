using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models.Enums;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Queries.GetForecastById;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Domain.Entities;

public class GetForecastByIdQuery : IRequest<Result<GetForecastByIdQueryDto>>
{
    public string? UniqueId { get; set; }
}


public class GetForecastByIdQueryHandler : IRequestHandler<GetForecastByIdQuery, Result<GetForecastByIdQueryDto>>
{
    private readonly IApplicationDbContext _context;

    public GetForecastByIdQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result<GetForecastByIdQueryDto>> Handle(GetForecastByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _context.Forecast.SingleOrDefaultAsync(i => i.UniqueId == request.UniqueId);

        if (result != null)
        {
            return new()
            {
                Data = new GetForecastByIdQueryDto
                {
                    Id = result.Id,
                    ForecastName = result.ForecastName,
                    City = result.City,
                    Temperature = result.Temperature,
                    ForecastDescription = result.ForecastDescription,
                    ForecastDate = result.ForecastDate,
                    ForecastMain = result.ForecastMain,
                    Pressure = result.Pressure,
                    Humidity = result.Humidity,
                    UniqueId = result.UniqueId,
                    IsActive = result.IsActive == null ? true : result.IsActive
                },
                Message = "success",
                ResultType = ResultType.Success,
            };
        }

        return new()
        {
            Data = new GetForecastByIdQueryDto
            {

            },
            Message = "failed - no record found",
            ResultType = ResultType.Error,
        };

    }
}
