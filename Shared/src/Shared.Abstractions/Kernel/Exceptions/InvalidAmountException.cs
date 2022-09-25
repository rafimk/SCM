using Shared.Abstractions.Exceptions;

namespace Shared.Abstractions.Kernel.Exceptions;

public class InvalidAmountException : CustomException
{
    public decimal Amount { get; }

    public InvalidAmountException(decimal amount) : base($"Amount: '{amount}' is invalid.")
    {
        Amount = amount;
    }
}