using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("SCM.ItemManagement.Api")]
[assembly: InternalsVisibleTo("SCM.ItemManagement.Infrastructure")]
namespace SCM.ItemManagement.Application;

internal static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}