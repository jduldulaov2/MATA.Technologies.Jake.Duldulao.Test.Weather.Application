using Microsoft.AspNetCore.Identity;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? Province { get; set; }
    public string? Region { get; set; }
    public string? ZipCode { get; set; }
    public string? ContactNumber { get; set; }
}
