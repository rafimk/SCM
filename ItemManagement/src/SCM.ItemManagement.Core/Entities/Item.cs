using SCM.ItemManagement.Core.ValueObjects;

namespace SCM.ItemManagement.Core.Entities;


public class Item
{
    public ItemId Id { get; private set; }
    public string Name { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? VerifiedAt { get; private set; }

    protected Item()
    {
    }

    public Item(ItemId id, string name, DateTime createdAt)
    {
        Id = id;
        Name = name;
        IsActive = true;
        CreatedAt = createdAt;
    }

    public void Verify(DateTime verifiedAt)
    {
        VerifiedAt = verifiedAt;
    }

    public bool Lock() => IsActive = false;
        
    public bool Unlock() => IsActive = true;
}