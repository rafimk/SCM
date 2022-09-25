using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Shared.Infrastructure.MSSqlServer;

public abstract class MSSqlServerUnitOfWork<T> : IUnitOfWork where T : DbContext
{
    private readonly T _dbContext;

    protected MSSqlServerUnitOfWork(T dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task ExecuteAsync(Func<Task> action)
    {
        await using var transaction = await _dbContext.Database.BeginTransactionAsync();
        try
        {
            await action();
            await transaction.CommitAsync();
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
}