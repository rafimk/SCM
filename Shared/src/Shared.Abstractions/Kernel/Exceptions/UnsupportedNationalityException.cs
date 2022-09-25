using Shared.Abstractions.Exceptions;

namespace Shared.Abstractions.Kernel.Exceptions;

public class UnsupportedNationalityException : CustomException
{
    public string Nationality { get; }

    public UnsupportedNationalityException(string nationality) : base($"Nationality: '{nationality}' is unsupported.")
    {
        Nationality = nationality;
    }
}