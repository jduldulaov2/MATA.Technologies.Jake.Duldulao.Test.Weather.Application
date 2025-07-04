﻿using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Exceptions;
using Microsoft.Extensions.Logging;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Behaviours;

public class DbUpdateConcurrencyExceptionBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
{
    private readonly ILogger<TRequest> _logger;

    public DbUpdateConcurrencyExceptionBehaviour(ILogger<TRequest> logger)
    {
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {

        try
        {
            return await next();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            var requestName = typeof(TRequest).Name;

            var errorMsg = ex.InnerException is not null ? ex.InnerException.Message : ex.Message;

            _logger.LogError(ex, "MATA.Technologies.Jake.Duldulao.Test.Weather.Application Request: DbUpdateConcurrency Exception for Request {Name} {@Request}", requestName, request);

            throw new DatabaseValueChangedException($"Data is out of date, refresh and try again.");

        }
    }
}
