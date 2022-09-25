using Shared.Infrastructure.MSSqlServer;

namespace SCM.ItemManagment.Infrastructure.EF;

internal class ItemMasterUnitOfWork : MSSqlServerUnitOfWork<ItemMasterDbContext>
{
    public ItemMasterUnitOfWork(ItemMasterDbContext dbContext) : base(dbContext)
    {
    }
}