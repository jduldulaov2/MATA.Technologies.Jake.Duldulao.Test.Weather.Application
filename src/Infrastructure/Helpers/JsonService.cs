using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;
using Newtonsoft.Json;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Infrastructure.Helpers;
public class JsonService : IJsonService
{
    public string ConvertToJson(object datatoconvert)
    {
        return JsonConvert.SerializeObject(datatoconvert);
    }

    public async Task<string> ConvertToJsonAsync(object datatoconvert)
    {
        var result = await Task.Factory.StartNew(
            () => JsonConvert.SerializeObject(datatoconvert, Formatting.None));

        return result;
    }

}

