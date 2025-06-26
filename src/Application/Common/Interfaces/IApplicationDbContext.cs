using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Domain.Entities;
using Microsoft.AspNetCore.Identity;

public interface IApplicationDbContext
{
    IQueryable<IdentityUser> Users { get; }

    DbSet<Forecast> Forecast { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
