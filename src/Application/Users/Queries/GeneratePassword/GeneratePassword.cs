using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models.Enums;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Users.Queries.GetUsers;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Users.Queries.GeneratePassword;
public record GeneratePasswordQuery : IRequest<Result<GeneratePasswordDto>>
{

}

public class GeneratePasswordQueryHandler : IRequestHandler<GeneratePasswordQuery, Result<GeneratePasswordDto>>
{
    private readonly IPassword _password;

    public GeneratePasswordQueryHandler(IPassword password)
    {
        _password = password;
    }

    public async Task<Result<GeneratePasswordDto>> Handle(GeneratePasswordQuery request, CancellationToken cancellationToken)
    {
        var password = await this._password.GeneratePasswordAsync(3, 3, 4);

        return new()
        {
            Data = new GeneratePasswordDto
            {
                Password = password
            },
            Message = "Password successfully generated.",
            ResultType = ResultType.Success,
        };
    }
}
