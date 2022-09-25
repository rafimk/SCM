using System;

namespace Shared.Abstractions.Time;

public interface IClock
{
    DateTime CurrentDate();
}