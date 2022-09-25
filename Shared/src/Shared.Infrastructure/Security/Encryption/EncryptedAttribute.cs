using System;

namespace Shared.Infrastructure.Security.Encryption;

[AttributeUsage(AttributeTargets.Property)]
public class EncryptedAttribute : Attribute
{
}