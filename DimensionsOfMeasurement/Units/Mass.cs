namespace DimensionsOfMeasurement.Units
{
    public static class Mass
    {
 		public static readonly UnitOfMeasure Kilogram  = UnitFactory.Create(Dimensionality.Mass, "kg", 1);
		public static readonly UnitOfMeasure Gram  = UnitFactory.Create(Kilogram, "g", 0.001);
		public static readonly UnitOfMeasure Milligram = Metric.m(Gram);
		public static readonly UnitOfMeasure Microgram = Metric.micro(Gram);
		public static readonly UnitOfMeasure Nanogram = Metric.n(Gram);
		public static readonly UnitOfMeasure Picogram = Metric.p(Gram);
		public static readonly UnitOfMeasure Femtogram = Metric.f(Gram);
		public static readonly UnitOfMeasure Attogram = Metric.a(Gram);
		public static readonly UnitOfMeasure Zeptogram = Metric.z(Gram);
		public static readonly UnitOfMeasure Yoctogram = Metric.y(Gram);
		public static readonly UnitOfMeasure Tonne  = UnitFactory.Create(Kilogram, "tonne", 1000);
		public static readonly UnitOfMeasure Megatonne = Metric.M(Tonne);
		public static readonly UnitOfMeasure Gigatonne = Metric.G(Tonne);
		public static readonly UnitOfMeasure Ounce  = UnitFactory.Create(Gram, "oz", 28.349523);
		public static readonly UnitOfMeasure Pound  = UnitFactory.Create(Ounce, "lb", 16);
		public static readonly UnitOfMeasure Ton  = UnitFactory.Create(Pound, "ton", 2000);
		public static readonly UnitOfMeasure Grain  = UnitFactory.Create(Gram, "gr", 0.064799);
		public static readonly UnitOfMeasure TroyOunce  = UnitFactory.Create(Grain, "oz t", 480);
    }
}
