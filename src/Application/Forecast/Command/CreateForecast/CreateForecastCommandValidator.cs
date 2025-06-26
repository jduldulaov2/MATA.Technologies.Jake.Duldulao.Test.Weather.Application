using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Command.CreateForecast;

public class CreateForecastCommandValidator : AbstractValidator<CreateForecastCommand>
{
    public CreateForecastCommandValidator()
    {
        RuleFor(v => v.ForecastName)
            .NotEmpty()
            .WithMessage("ForecastName is required.");
        RuleFor(v => v.ForecastDescription)
            .NotEmpty()
            .WithMessage("ForecastDescription is required.");
        RuleFor(v => v.ForecastDate)
            .NotEmpty()
            .WithMessage("ForecastDate is required.");
        RuleFor(v => v.ForecastMain)
            .NotEmpty()
            .WithMessage("ForecastMain is required.");
        RuleFor(v => v.Pressure)
            .NotEmpty()
            .WithMessage("Pressure is required.");
        RuleFor(v => v.Humidity)
            .NotEmpty()
            .WithMessage("Humidity is required.");
    }
}
