namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Users.Commands.UpdatePassword;

public class UpdatePasswordCommandValidator : AbstractValidator<UpdatePasswordCommand>
{
    public UpdatePasswordCommandValidator()
    {
        RuleFor(v => v.UserName)
            .NotEmpty();

        RuleFor(v => v.OldPassword)
            .NotEmpty();

        RuleFor(v => v.NewPassword)
            .NotEmpty();
    }
}
