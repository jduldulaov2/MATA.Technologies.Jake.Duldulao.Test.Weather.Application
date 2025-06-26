using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Command.CreateForecast;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Command.UpdateForecast;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Web.Endpoints;

public class Forecasts : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapPost(CreateForecast, "CreateForecast")
            .MapPut(UpdateForecast, "UpdateForecast")
            ;
    }

    public Task<Result<CreateForecastCommandDto>> CreateForecast(ISender sender, CreateForecastCommand command)
    {
        return sender.Send(command);
    }

    public Task<Result<UpdateForecastCommandDto>> UpdateForecast(ISender sender, UpdateForecastCommand command)
    {
        return sender.Send(command);
    }
}
