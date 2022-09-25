using System.Linq.Expressions;
using SCM.ItemManagement.Core.Entities;
using Shared.Abstractions.Queries;

namespace SCM.ItemManagement.Application.Storage;

public interface IItemStorage
{
    Task<Item> FindAsync(Expression<Func<Item, bool>> expression);
    Task<Paged<Item>> BrowseAsync(Expression<Func<Item, bool>> expression, IPagedQuery query);
}