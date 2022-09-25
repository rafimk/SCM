using Shared.Abstractions.Commands;
using Shared.Abstractions.Messaging;
using Shared.Abstractions.Time;
using Microsoft.Extensions.Logging;
using SCM.ItemManagement.Core.Repositories;

namespace SCM.ItemManagement.Application.Commands.Handlers;

internal sealed class AddItemHandlers : ICommandHandler<AddItem>
{
    private readonly IItemRepository _itemRepository;
    private readonly IClock _clock;
    private readonly IMessageBroker _messageBroker;
    private readonly ILogger<AddItemHandlers> _logger;

    public AddItemHandlers(IItemRepository itemRepository, IClock clock, IMessageBroker messageBroker,
        ILogger<AddItemHandlers> logger)
    {
        _itemRepository = itemRepository;
        _clock = clock;
        _messageBroker = messageBroker;
        _logger = logger;
    }

    public async Task HandleAsync(AddItem command, CancellationToken cancellationToken = default)
    {
        var wallet = await _itemRepository.GetAsync(command.ItemId);

        // var transfer = wallet.AddFunds(command.TransferId, command.Amount, _clock.CurrentDate(),
        //     command.TransferName, command.TransferMetadata);
        // await _walletRepository.UpdateAsync(wallet);
        // await _messageBroker.PublishAsync(new FundsAdded(wallet.Id, wallet.OwnerId, wallet.Currency,
        //     transfer.Amount, transfer.Name, transfer.Metadata), cancellationToken);
        // _logger.LogInformation($"Added {transfer.Amount} {transfer.Currency} to wallet with ID: '{wallet.Id}'.");
    }
}