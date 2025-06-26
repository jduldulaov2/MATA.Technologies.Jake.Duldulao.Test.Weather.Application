
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Commands.Login;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Commands.Logout;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Auth.Queries.GetLoggedIn;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Users.Commands.CreateUser;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Users.Commands.UpdatePassword;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Users.Commands.UpdateUser;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Users.Queries.GetUserByID;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Users.Queries.GetUsers;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;

public interface IIdentityService
{
    Task<string?> GetUserNameAsync(string userId);

    Task<bool> IsInRoleAsync(string? userId, string? role);

    Task<bool> AuthorizeAsync(string userId, string policyName);

    Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);

    Task<Result> DeleteUserAsync(string userId);

    Task<List<string>> GetUserRoles(string userId);

    Task<bool> IsValidCredential(string username, string password);

    Task<bool> IsValidUserId(string userid);

    Task<UserByIDDto> UserDetails(string userid);

    Task<Result<UsersListDto>> AllUsersByName(string username);

    Task<Result<LoginDto>> LoginAsync(string? username, string? password, bool isPersisted = false, bool lockOutOnFailure = false);

    Task<Result<LogoutDto>> LogOut(string? userid);

    Task<Result<CreateUserDto>> CreateIdentityUserAsync(string? userName, string? password, string? lastName, string? firstName, string? middleName, string? emailAddress, string? street, string? city, string? province, string? region, string? zipCode, string? contactNumber);

    Task<Result<UpdateUserDto>> UpdateIdentityUserAsync(string? id, string? userName, string? lastName, string? firstName, string? middleName, string? emailAddress, string? street, string? city, string? province, string? region, string? zipCode, string? contactNumber);

    Task<Result<UpdatePasswordDto>> UpdateIdentityUserPasswordAsync(string? userName, string? oldPassword, string? newPassword);

    Task<Result<UserByIDDto>> GetUserById(string? id);

    Task<Result<GetLoggedInQueryDto>> GetLoggedIn();
}
