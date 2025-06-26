using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Command.CreateForecast;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Command.UpdateForecast;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Queries.GetAllForecast;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Queries.GetForecastById;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Web.Endpoints;

public class Forecasts : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetAllForcast, "GetAllForcast")
            .MapGet(GetAllForcastByID, "GetAllForcastByID")
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

    public async Task<List<GetAllForecastQueryDto>> GetAllForcast(ISender sender, [AsParameters] GetAllForecastQuery query)
    {
        return await sender.Send(query);
    }

    public async Task<Result<GetForecastByIdQueryDto>> GetAllForcastByID(ISender sender, [AsParameters] GetForecastByIdQuery query)
    {
        return await sender.Send(query);
    }
}
