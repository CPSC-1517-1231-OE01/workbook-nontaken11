namespace Utils
{
    public static class Utilities
    {
        // Method to check if a value is in hundreds
        public static bool InHundreds(int value)
        {
            return (value >= 100 && value <= 999);
        }

        // Method to check if a value is positive and non-zero
        public static bool IsPositiveNonZero(int value)
        {
            return (value > 0);
        }
    }
}