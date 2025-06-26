using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Users.Commands.UpdateUser;

public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(v => v.Id)
            .NotEmpty();

        RuleFor(v => v.UserName)
            .NotEmpty();

        RuleFor(v => v.LastName)
            .NotEmpty();

        RuleFor(v => v.FirstName)
            .NotEmpty();

        RuleFor(v => v.EmailAddress)
            .NotEmpty();
    }
}
