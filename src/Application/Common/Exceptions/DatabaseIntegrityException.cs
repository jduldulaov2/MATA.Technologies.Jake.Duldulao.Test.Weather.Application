namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Exceptions;

public class DatabaseIntegrityException : Exception
{
    public DatabaseIntegrityException()
    {
    }

    public DatabaseIntegrityException(string message) : base(message)
    {
    }

    public DatabaseIntegrityException(string message, Exception inner) : base(message, inner)
    {
    }
}
