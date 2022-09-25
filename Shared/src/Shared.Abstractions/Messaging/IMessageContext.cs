using System;
using Shared.Abstractions.Contexts;

namespace Shared.Abstractions.Messaging;

public interface IMessageContext
{
    public Guid MessageId { get; }
    public IContext Context { get; }
}