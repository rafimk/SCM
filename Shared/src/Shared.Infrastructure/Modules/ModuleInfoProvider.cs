using System.Collections.Generic;

namespace Shared.Infrastructure.Modules;

internal class ModuleInfoProvider
{
    public List<ModuleInfo> Modules { get; } = new();
}