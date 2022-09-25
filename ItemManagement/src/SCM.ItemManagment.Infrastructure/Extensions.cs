using Microsoft.Extensions.DependencyInjection;
using SCM.ItemManagement.Application.Storage;
using SCM.ItemManagement.Core.Repositories;
using SCM.ItemManagment.Infrastructure.EF;
using SCM.ItemManagment.Infrastructure.EF.Repositories;
using SCM.ItemManagment.Infrastructure.Storage;
using Shared.Infrastructure.Messaging.Outbox;
using Shared.Infrastructure.MSSqlServer;

namespace SCM.ItemManagment.Infrastructure;

internal static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services
            .AddScoped<IItemStorage, ItemStorage>()
            .AddScoped<IItemRepository, ItemRepository>()
            .AddMSSqlServer<ItemMasterDbContext>()
            .AddOutbox<ItemMasterDbContext>()
            .AddUnitOfWork<ItemMasterUnitOfWork>();
    }
}