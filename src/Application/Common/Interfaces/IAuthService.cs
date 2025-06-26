namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;

public interface IAuthService
{
    Task<bool> SignIn(string username, string password);
    Task SignOut();
}
