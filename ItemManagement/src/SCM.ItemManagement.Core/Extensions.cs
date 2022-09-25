using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("SCM.ItemManagement.Api")]
[assembly: InternalsVisibleTo("SCM.ItemManagement.Application")]
[assembly: InternalsVisibleTo("SCM.ItemManagement.Infrastructure")]

namespace SCM.ItemManagement.Core;

internal static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services;
    }
}