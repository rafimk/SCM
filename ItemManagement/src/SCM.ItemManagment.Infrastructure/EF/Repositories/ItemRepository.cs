using Microsoft.EntityFrameworkCore;
using SCM.ItemManagement.Core.Entities;
using SCM.ItemManagement.Core.Repositories;
using SCM.ItemManagement.Core.ValueObjects;

namespace SCM.ItemManagment.Infrastructure.EF.Repositories;


internal class ItemRepository : IItemRepository
{
    private readonly ItemMasterDbContext _context;
    private readonly DbSet<Item> _wallets;
        
    public ItemRepository(ItemMasterDbContext context)
    {
        _context = context;
        _wallets = _context.Items;
    }
        
    public Task<Item> GetAsync(ItemId id)
        => _wallets
            .SingleOrDefaultAsync(x => x.Id == id);

    
    public async Task AddAsync(Item item)
    {
        await _wallets.AddAsync(item);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Item item)
    {
        _wallets.Update(item);
        await _context.SaveChangesAsync();
    }
}