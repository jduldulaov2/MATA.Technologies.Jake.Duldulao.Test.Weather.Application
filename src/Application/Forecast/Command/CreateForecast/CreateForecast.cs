using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models.Enums;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Command.CreateForecast;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Domain.Entities;

public record CreateForecastCommand : IRequest<Result<CreateForecastCommandDto>>
{
    public string? ForecastName { get; init; }

    public string? ForecastDescription { get; init; }

    public string? ForecastDate { get; init; }

    public string? ForecastMain { get; init; }

    public string? Pressure { get; init; }

    public string? Humidity { get; init; }
}

public class CreateForecastCommandHandler : IRequestHandler<CreateForecastCommand, Result<CreateForecastCommandDto>>
{
    private readonly IApplicationDbContext _context;

    public CreateForecastCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result<CreateForecastCommandDto>> Handle(CreateForecastCommand request, CancellationToken cancellationToken)
    {
        var record = await _context.Forecast.Where(p => p.ForecastName == request.ForecastName).ToListAsync();

        if (record.Count == 0)
        {

            // Add new record

            var entity = new Forecast();

            entity.ForecastName = request.ForecastName;

            entity.ForecastDescription = request.ForecastDescription;

            entity.ForecastDate = request.ForecastDate;

            entity.ForecastMain = request.ForecastMain;

            entity.Pressure = request.Pressure;

            entity.Humidity = request.Humidity;

            _context.Forecast.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return new()
            {
                Data = new CreateForecastCommandDto
                {
                    Id = entity.UniqueId,
                    CreatedDate = DateTime.Now,
                },
                Message = "success",
                ResultType = ResultType.Success,
            };
        }
        else
        {
            return new()
            {
                Data = new CreateForecastCommandDto
                {

                },
                Message = "Record '" + request.ForecastName + "' already exist",
                ResultType = ResultType.Error,
            };
        }
    }
}
