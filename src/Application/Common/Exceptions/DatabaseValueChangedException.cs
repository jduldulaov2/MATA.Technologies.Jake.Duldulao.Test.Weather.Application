namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Exceptions;

public class DatabaseValueChangedException : Exception
{
    public DatabaseValueChangedException()
    {
    }

    public DatabaseValueChangedException(string message) : base(message)
    {
    }

    public DatabaseValueChangedException(string message, Exception inner) : base(message, inner)
    {
    }
}
