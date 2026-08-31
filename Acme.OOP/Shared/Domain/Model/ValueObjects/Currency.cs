namespace Acme.OOP.Shared.Domain.Model.ValueObjects;

/// <summary>
/// Represents a currency in the ISO 4217 format.
/// </summary>

public readonly record struct Currency
{
    public string Code
    {
        get => field ?? string.Empty;
        init 
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(value);
            if((value.Length != 3) || !value.All(char.IsAsciiLetter))
                throw new ArgumentException("Currency code must be 3-letter ISO 4217 code.");
            field = value.ToUpperInvariant();
        }
    }

    /// <summary>
    /// Prevents the default constructor from being used, ensuring that a valid ISO 4217 code is always provided. 
    /// </summary>
    /// <exception cref="InvalidOperationException">Always thrown because currency code is invalid</exception>
    public Currency() => throw new InvalidOperationException("Currency must be initialized with 3-letter ISO  4217 code.");
    /// <summary>
    /// Creates a new instance of <see cref="Currency"/>
    /// </summary>
    /// <param name="code">The ISO 4217 code for the currency</param>
    public Currency(string code) => Code = code;

    public override string ToString() => Code;
}