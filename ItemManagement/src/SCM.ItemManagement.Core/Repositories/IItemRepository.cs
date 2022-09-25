using SCM.ItemManagement.Core.Entities;
using SCM.ItemManagement.Core.ValueObjects;

namespace SCM.ItemManagement.Core.Repositories;


public interface IItemRepository
{
    Task<Item> GetAsync(ItemId id);
    Task AddAsync(Item item);
    Task UpdateAsync(Item item);
}