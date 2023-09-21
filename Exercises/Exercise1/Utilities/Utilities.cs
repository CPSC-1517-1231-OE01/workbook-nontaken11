namespace Utils
{
    public static class Utilities
    {
        public static bool InHundreds(int value)
        {
            return (value >= 100 && value <= 999);
        }

        public static bool IsPositiveNonZero(int value)
        {
            return (value > 0);
        }
    }
}