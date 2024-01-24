namespace DimensionsOfMeasurement;

public class Delta : BaseQuantity
{
    protected override string ToStringSuffix { get; } = "(Δ)";

    public Delta(double value, UnitOfMeasure unitOfMeasure) : base(value, unitOfMeasure)
    { }

    public Delta(Quantity quantity) : base(quantity)
    { }

    public override double In(UnitOfMeasure unitOfMeasure)
    {
        if (unitOfMeasure is OffsetUnitOfMeasure offsetUnit)
        {
            return base.In(offsetUnit.DeltaUnit);
        }

        return base.In(unitOfMeasure);
    }

    public override double TryIn(UnitOfMeasure unitOfMeasure)
    {
        if (unitOfMeasure is OffsetUnitOfMeasure offsetUnit)
        {
            return base.TryIn(offsetUnit.DeltaUnit);
        }

        return base.TryIn(unitOfMeasure);
    }

    public Delta ToPower(int exponent)
    {
        return new Delta(Quantity.ToPower(exponent));
    }

    public Delta ToRoot(int root)
    {
        return new Delta(Quantity.ToRoot(root));
    }

    public Delta TryAdd(Delta other)
    {
        return new Delta(Quantity.TryAdd(other.Quantity));
    }

    public Delta TrySubtract(Delta other)
    {
        return new Delta(Quantity.TrySubtract(other.Quantity));
    }

    public Delta Plus(Delta other)
    {
        return new Delta(Quantity + other.Quantity);
    }

    public Delta Minus(Delta other)
    {
        return new Delta(Quantity - other.Quantity);
    }

    public Delta Times(Delta other)
    {
        return new Delta(Quantity * other.Quantity);
    }

    public Delta DividedBy(Delta other)
    {
        return new Delta(Quantity / other.Quantity);
    }
}
