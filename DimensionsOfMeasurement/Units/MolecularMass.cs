using Uom = DimensionsOfMeasurement.UnitOfMeasure;

namespace DimensionsOfMeasurement.Units;

public static class MolecularMass
{
    public static readonly Uom GramPerMole = UnitFactory.Create(
        (Mass.Gram, 1),
        (Moles.Mole, -1));

    public static readonly Uom KgPerKmol = UnitFactory.Create(
        (Mass.Kilogram, 1),
        (Moles.Kilomole, -1));

    public static readonly Uom GramPerKmol = UnitFactory.Create(
        (Mass.Gram, 1),
        (Moles.Kilomole, -1));

    public static readonly Uom KgPerMole = UnitFactory.Create(
        (Mass.Kilogram, 1),
        (Moles.Mole, -1));
}
