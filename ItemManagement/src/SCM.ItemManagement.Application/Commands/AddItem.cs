using Shared.Abstractions.Commands;

namespace SCM.ItemManagement.Application.Commands;

internal record AddItem(Guid ItemId, string Name) : ICommand;
