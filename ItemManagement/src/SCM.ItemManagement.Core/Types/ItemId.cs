using Shared.Abstractions.Kernel.Types;

namespace SCM.ItemManagement.Core.ValueObjects;


public class ItemId : TypeId
{
    public ItemId(Guid value) : base(value)
    {
    }
        
    public static implicit operator ItemId(Guid id) => new(id);
        
    public static implicit operator Guid(ItemId id) => id.Value;
}