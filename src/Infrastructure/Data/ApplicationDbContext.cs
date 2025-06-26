using System.Reflection;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Domain.Entities;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Forecast> Forecast => Set<Forecast>();

    IQueryable<IdentityUser> IApplicationDbContext.Users => this.Users;
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
