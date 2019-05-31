using System;

namespace CSharpSevenFeatures
{
    public struct ReadonlyStruct
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double Distance => Math.Sqrt(X * Y + Y * X);

        public override string ToString() => $"({X}, {Y}) is {Distance} from the origin.";

    }
}
