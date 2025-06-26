namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;
public interface IPassword
{
    Task<string> GeneratePasswordAsync(int lowercase, int uppercase, int numerics);
}
