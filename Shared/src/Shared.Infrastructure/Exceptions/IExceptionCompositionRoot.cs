using System;
using Shared.Abstractions.Exceptions;

namespace Shared.Infrastructure.Exceptions;

public interface IExceptionCompositionRoot
{
    ExceptionResponse Map(Exception exception);
}