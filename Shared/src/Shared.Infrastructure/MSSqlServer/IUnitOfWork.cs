using System;
using System.Threading.Tasks;

namespace Shared.Infrastructure.MSSqlServer;

public interface IUnitOfWork
{
    Task ExecuteAsync(Func<Task> action);
}