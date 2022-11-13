namespace Static_Demo
{
    public static class Mathematics
    {
        private static double pi = 3.14;

        public static int Add(int a, int b)
            => a + b;

        public static int Multiply(int a, int b)
            => a * b;

        public static double CircleArea(int radius)
            => pi * radius * radius;
    }
}
