using SCM.ItemManagement.Application.DTO;
using SCM.ItemManagement.Core.Entities;

namespace SCM.ItemManagement.Application.Queries.Handlers;

internal static class Extensions
{
    public static ItemDto AsDto(this Item item)
        => item.Map<ItemDto>();
    
    private static T Map<T>(this Item item) where T : ItemDto, new()
        => new()
        {
            Id = item.Id,
            Name = item.Name,
            CreatedAt = item.CreatedAt,
        };
    
}