using SCM.ItemManagement.Application.DTO;
using Shared.Abstractions.Queries;

namespace SCM.ItemManagement.Application.Queries;


internal class GetItem : IQuery<ItemDto>
{
    public Guid ItemId { get; set; }
}