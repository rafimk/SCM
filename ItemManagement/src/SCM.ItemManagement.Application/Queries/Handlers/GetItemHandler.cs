using SCM.ItemManagement.Application.DTO;
using SCM.ItemManagement.Application.Storage;
using Shared.Abstractions.Contexts;
using Shared.Abstractions.Queries;

namespace SCM.ItemManagement.Application.Queries.Handlers;

internal sealed class GetItemHandler : IQueryHandler<GetItem, ItemDto>
{
    private readonly IItemStorage _storage;
    private readonly IContext _context;

    public GetItemHandler(IItemStorage storage, IContext context)
    {
        _storage = storage;
        _context = context;
    }

    public async Task<ItemDto> HandleAsync(GetItem query, CancellationToken cancellationToken = default)
    {
        // Owner cannot access the other wallets
        var item = await _storage.FindAsync(x => x.Id == query.ItemId);
        if (item is null)
        {
            return null;
        }
            
        return item.AsDto();
    }
}