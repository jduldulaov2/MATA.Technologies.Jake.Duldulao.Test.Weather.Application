using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Forecast.Queries.GetForecastByCityRecent;
public class GetForecastByCityRecentQueryDto
{
    public int? Id { get; set; }

    public string? ForecastName { get; set; }

    public string? City { get; set; }

    public string? Temperature { get; set; }

    public string? ForecastDescription { get; set; }

    public string? ForecastDate { get; set; }

    public string? ForecastMain { get; set; }

    public string? Pressure { get; set; }

    public string? Humidity { get; set; }

    public string? UniqueId { get; set; }

    public bool? IsActive { get; set; }
}
