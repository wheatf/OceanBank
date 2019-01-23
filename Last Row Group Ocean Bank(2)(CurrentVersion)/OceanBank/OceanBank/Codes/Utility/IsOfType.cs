namespace OceanBank.Codes.Utility
{
    public static class IsOfType
    {
        public static bool IsInt(this string value)
        {
            int ignore;
            return int.TryParse(value, out ignore);
        }

        public static bool IsDouble(this string value)
        {
            double ignore;
            return double.TryParse(value, out ignore);
        }
    }
}
