using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models.Enums;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Command.UpdateForecast;

public record UpdateForecastCommand : IRequest<Result<UpdateForecastCommandDto>>
{
    public string? UniqueId { get; init; }

    public string? ForecastName { get; init; }

    public string? City { get; init; }

    public string? Temperature { get; init; }

    public string? ForecastDescription { get; init; }

    public string? ForecastDate { get; init; }

    public string? ForecastMain { get; init; }

    public string? Pressure { get; init; }

    public string? Humidity { get; init; }

    public bool? IsActive { get; init; }
}

public class UpdateForecastCommandHandler : IRequestHandler<UpdateForecastCommand, Result<UpdateForecastCommandDto>>
{
    private readonly IApplicationDbContext _context;

    public UpdateForecastCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result<UpdateForecastCommandDto>> Handle(UpdateForecastCommand request, CancellationToken cancellationToken)
    {
        var record = _context.Forecast.FirstOrDefault(item => item.ForecastName == request.ForecastName && item.UniqueId != request.UniqueId);

        if (record == null)
        {
            var entity = _context.Forecast.FirstOrDefault(item => item.UniqueId == request.UniqueId);

            if (entity != null)
            {
                entity.ForecastName = request.ForecastName;

                entity.City = request.City;

                entity.Temperature = request.Temperature;

                entity.ForecastDescription = request.ForecastDescription;

                entity.ForecastDate = request.ForecastDate;

                entity.ForecastMain = request.ForecastMain;

                entity.Pressure = request.Pressure;

                entity.Humidity = request.Humidity;

                entity.IsActive = request.IsActive;

                _context.Forecast.Update(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return new()
                {
                    Data = new UpdateForecastCommandDto
                    {
                        Id = entity.UniqueId,
                        UpdatedDate = DateTime.Now,
                    },
                    Message = "Updated successfully.",
                    ResultType = ResultType.Success,
                };
            }
        }
        else
        {
            return new()
            {
                Data = new UpdateForecastCommandDto
                {

                },
                Message = "Record '" + request.ForecastName + "' already exist.",
                ResultType = ResultType.Error,
            };
        }

        return new()
        {
            Data = new UpdateForecastCommandDto
            {

            },
            Message = "No record found.",
            ResultType = ResultType.Error,
        };

    }
}
