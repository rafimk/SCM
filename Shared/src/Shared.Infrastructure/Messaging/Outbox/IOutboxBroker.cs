using System.Threading.Tasks;
using Shared.Abstractions.Messaging;

namespace Shared.Infrastructure.Messaging.Outbox;

public interface IOutboxBroker
{
    bool Enabled { get; }
    Task SendAsync(params IMessage[] messages);
}