using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Commands.ExternalLogin;
public class ExchangeCodeRequest
{
    public string login { get; set; } = default!;       // GitHub username
    public string name { get; set; } = default!;        // Full name
    public string email { get; set; } = default!;
    public string avatar_url { get; set; } = default!;
    public string html_url { get; set; } = default!;
}
