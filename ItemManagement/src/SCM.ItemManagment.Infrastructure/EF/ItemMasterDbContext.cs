using Microsoft.EntityFrameworkCore;
using Shared.Infrastructure.Messaging.Outbox;
using SCM.ItemManagement.Core.Entities;

namespace SCM.ItemManagment.Infrastructure.EF;

internal class ItemMasterDbContext : DbContext
{
    public DbSet<InboxMessage> Inbox { get; set; }
    public DbSet<OutboxMessage> Outbox { get; set; }
    public DbSet<Item> Items { get; set; }
        
    public ItemMasterDbContext(DbContextOptions<ItemMasterDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("ItemMaster");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}