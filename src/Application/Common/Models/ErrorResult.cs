using System.Text.Json;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models.Enums;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;

public class ErrorResult
{
    public ErrorResult() => ResultType = ResultType.Error;

    public ResultType ResultType { get; set; }
    public string Message { get; set; } = null!;

    public override string ToString() => JsonSerializer.Serialize(this, DefaultSerializerOptions());

    private static JsonSerializerOptions DefaultSerializerOptions() => new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
}
