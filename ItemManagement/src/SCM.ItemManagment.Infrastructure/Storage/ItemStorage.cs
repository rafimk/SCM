using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SCM.ItemManagement.Application.Storage;
using SCM.ItemManagement.Core.Entities;
using SCM.ItemManagment.Infrastructure.EF;
using Shared.Abstractions.Queries;
using Shared.Infrastructure.MSSqlServer;

namespace SCM.ItemManagment.Infrastructure.Storage;


internal sealed class ItemStorage : IItemStorage
{
    private readonly DbSet<Item> _items;

    public ItemStorage(ItemMasterDbContext dbContext)
    {
        _items = dbContext.Items;
    }

    public Task<Item> FindAsync(Expression<Func<Item, bool>> expression)
        => _items
            .AsNoTracking()
            .AsQueryable()
            .Where(expression)
            .SingleOrDefaultAsync();

    public Task<Paged<Item>> BrowseAsync(Expression<Func<Item, bool>> expression, IPagedQuery query)
        => _items
            .AsNoTracking()
            .AsQueryable()
            .Where(expression)
            .OrderBy(x => x.CreatedAt)
            .PaginateAsync(query);
}