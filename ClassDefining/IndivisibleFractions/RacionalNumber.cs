namespace IndivisibleFractions
{
    public class RacionalNumber
    {
        private int numerator;
        private int denumerator;

        public RacionalNumber(int numerator, int denumerator)
        {
            this.numerator = numerator;
            this.denumerator = denumerator;
        }

        public static RacionalNumber Normalize(RacionalNumber racionalNumber)
        {
            int bigestDivider = BigestDivider(racionalNumber.numerator, racionalNumber.denumerator);

            int normalizedNumerator = racionalNumber.numerator / bigestDivider;
            int normalizedDenumerator = racionalNumber.denumerator / bigestDivider;
            RacionalNumber normalizedRacionalNumber = new RacionalNumber(normalizedNumerator, normalizedDenumerator);

            return normalizedRacionalNumber;
        }

        public override string ToString()
        {
            return $"{numerator}/{denumerator}";
        }

        private static int BigestDivider(int a, int b)
        {
            if (a == b)
            {
                return a;
            }

            if (a > b)
            {
                return BigestDivider(a - b, a);
            }

            return BigestDivider(a, b - a);
        }
    }
}
