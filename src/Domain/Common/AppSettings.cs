using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Domain.Common;
public class AppSettings
{
    public string? ClientSecret { get; set; }
    public string? ClientId { get; set; }
    public string? RedirectUri { get; set; }
    public string? AuthAccessTokenUrl { get; set; }
    public string? ReponseAPI { get; set; }
}
