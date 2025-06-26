using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Azure.Core;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Exceptions;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Models;
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Infrastructure.Data.Interceptors;

public sealed class SoftDeleteInterceptor : SaveChangesInterceptor
{
    private readonly IUser _user;

    public SoftDeleteInterceptor(IUser user)
    {
        _user = user;
    }

    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        // Perform Soft Delete
        PerformSoftDelete(eventData.Context);

        return base.SavingChanges(eventData, result);
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        // Perform Soft Delete
        PerformSoftDelete(eventData.Context);

        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private  void PerformSoftDelete(DbContext? context)
    {
        if (context == null) return;

        IEnumerable<EntityEntry<ISoftDeletable>> entries =
            context
                .ChangeTracker
                .Entries<ISoftDeletable>()
                .Where(e => e.State == EntityState.Deleted);


        foreach (EntityEntry<ISoftDeletable> softDeletable in entries)
        {
            softDeletable.State = EntityState.Modified;

            softDeletable.Entity.IsDeleted = true;
            softDeletable.Entity.Deleted = DateTime.UtcNow;
            softDeletable.Entity.DeletedBy = this._user.Id;
        }
    }
}
