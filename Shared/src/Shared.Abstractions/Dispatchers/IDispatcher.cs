using System.Threading;
using System.Threading.Tasks;
using Shared.Abstractions.Commands;
using Shared.Abstractions.Events;
using Shared.Abstractions.Queries;

namespace Shared.Abstractions.Dispatchers;

public interface IDispatcher
{
    Task SendAsync<T>(T command, CancellationToken cancellationToken = default) where T : class, ICommand;
    Task PublishAsync<T>(T @event, CancellationToken cancellationToken = default) where T : class, IEvent;
    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
}