using DimensionsOfMeasurement.Exceptions;

namespace DimensionsOfMeasurement;

public class Magnitude : BaseQuantity
{
    protected override string ToStringSuffix { get; } = "(+)";

    public Magnitude(double value, UnitOfMeasure unitOfMeasure) : base(value, unitOfMeasure)
    {
        if (double.IsNegative(value)) throw new NegativeMagnitudeException("Magnitude cannot be negative");
    }

    public Magnitude(Quantity quantity) : base(quantity)
    {
        if (quantity.IsNegative()) throw new NegativeMagnitudeException("Magnitude cannot be negative");
    }

    public Magnitude ToPower(int exponent)
    {
        return new Magnitude(Quantity.ToPower(exponent));
    }

    public Magnitude ToRoot(int root)
    {
        return new Magnitude(Quantity.ToRoot(root));
    }

    public Magnitude TryAdd(Magnitude other)
    {
        return new Magnitude(Quantity.TryAdd(other.Quantity));
    }

    public Magnitude TryAdd(Delta other)
    {
        var quantity = Quantity.TryAdd(other.Quantity);
        if (quantity.IsNegative())
        {
            quantity = new Quantity(0, quantity.Dimensionality);
        }

        return new Magnitude(quantity);
    }

    public Delta TrySubtract(Magnitude other)
    {
        return new Delta(Quantity.TrySubtract(other.Quantity));
    }

    public Magnitude TrySubtract(Delta other)
    {
        var quantity = Quantity.TrySubtract(other.Quantity);
        if (quantity.IsNegative())
        {
            quantity = new Quantity(0, quantity.Dimensionality);
        }

        return new Magnitude(quantity);
    }

    public Magnitude Plus(Magnitude other)
    {
        return new Magnitude(Quantity + other.Quantity);
    }

    public Delta Plus(Delta other)
    {
        return new Delta(Quantity + other.Quantity);
    }

    public Delta Minus(Magnitude other)
    {
        return new Delta(Quantity - other.Quantity);
    }

    public Magnitude Minus(Delta other)
    {
        return new Magnitude(Quantity - other.Quantity);
    }

    public Magnitude Times(Magnitude other)
    {
        return new Magnitude(Quantity * other.Quantity);
    }

    public Delta Times(Delta other)
    {
        return new Delta(Quantity * other.Quantity);
    }

    public Magnitude DividedBy(Magnitude other)
    {
        return new Magnitude(Quantity / other.Quantity);
    }

    public Delta DividedBy(Delta other)
    {
        return new Delta(Quantity / other.Quantity);
    }

    public static implicit operator Delta(Magnitude x)
    {
        return new Delta(x.Quantity);
    }
}
