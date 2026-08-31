namespace Acme.OOP.Shared.Domain.Model.ValueObjects;

/// <summary>
/// Represents a monetary value with an amount and currency.
/// </summary>

public readonly record struct Money
{
    public decimal Amount
    {
        get;
        init
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            field = value;
        }
    }
    /// <summary>
    /// the currency of the monetary value
    /// </summary>
    /// <exception cref="ArgumentNullException"></exception>
    public Currency Currency
    {
        get;
        init
        {
            if (value == default)
            {
                throw new ArgumentNullException(nameof(Currency));
                field = value;
            }
        }
    }
}