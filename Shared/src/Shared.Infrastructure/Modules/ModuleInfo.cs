using System.Collections.Generic;

namespace Shared.Infrastructure.Modules;

internal record ModuleInfo(string Name, IEnumerable<string> Policies);