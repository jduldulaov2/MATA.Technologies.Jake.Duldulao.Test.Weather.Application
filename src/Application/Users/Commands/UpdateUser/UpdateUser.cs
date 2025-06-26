
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Users.Commands.UpdateUser;
public record UpdateUserCommand : IRequest<Result<UpdateUserDto>>
{
    public string? Id { get; init; }

    public string? UserName { get; init; }

    public string? LastName { get; init; }

    public string? FirstName { get; init; }

    public string? MiddleName { get; init; }

    public string? EmailAddress { get; init; }

    public string? Street { get; init; }

    public string? City { get; init; }

    public string? Province { get; init; }

    public string? Region { get; init; }

    public string? ZipCode { get; init; }

    public string? ContactNumber { get; init; }
}

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Result<UpdateUserDto>>
{
    private readonly IIdentityService _identityService;
    public UpdateUserCommandHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    public async Task<Result<UpdateUserDto>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        return await _identityService.UpdateIdentityUserAsync(
           request.Id, request.UserName,  request.LastName, request.FirstName, request.MiddleName,
           request.EmailAddress, request.Street, request.City, request.Province, request.Region,
           request.ZipCode, request.ContactNumber);
    }
}
