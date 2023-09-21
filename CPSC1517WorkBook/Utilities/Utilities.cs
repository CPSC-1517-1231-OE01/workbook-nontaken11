namespace Utils
{
    public static class Utilities
    {
        public static bool IsPositive(int value)
        {
            return value > 0 ? true : false;
        }

        public static bool IsNegative(int value)
        {
            return value < 0;
        }

        public static bool IsZeroOrPositive(int value) => value >= 0;

        public static bool IsZeroOrNegative(int value) => value <= 0;

        public static bool IsPositive(double value) => value > 0.0;

        public static bool IsNegative(double value) => value < 0.0;

        public static bool IsZeroOrPositive(double value) => value >= 0.0;

        public static bool IsZeroOrNegative(double value) => value <= 0.0;

        public static bool IsPositive(decimal value) => value > 0;

        public static bool IsNegative(decimal value) => value < 0;

        public static bool IsZeroOrPositive(decimal value) => value >= 0;

        public static bool IsZeroOrNegative(decimal value) => value <= 0;

        public static bool IsNullEmptyOrWhiteSpace(string value) =>
            String.IsNullOrWhiteSpace(value);

        public static bool IsInTheFuture(DateTime value) => value >= DateTime.Now;

        public static bool IsInTheFuture(DateOnly value) =>
            value > DateOnly.FromDateTime(DateTime.Now);
    }
}