using Shared.Abstractions.Exceptions;

namespace Shared.Abstractions.Kernel.Exceptions;

public class InvalidNationalityException : CustomException
{
    public string Nationality { get; }

    public InvalidNationalityException(string nationality) : base($"Nationality: '{nationality}' is invalid.")
    {
        Nationality = nationality;
    }
}