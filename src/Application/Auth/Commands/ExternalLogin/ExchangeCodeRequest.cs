using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Commands.ExternalLogin;
public class ExchangeCodeRequest
{
    public string Code { get; set; } = default!;
    public string RedirectUri { get; set; } = default!;
}
