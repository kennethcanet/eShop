namespace eShop.Helpers;

public static class StringExtensions
{
    public static string Shorten(this string input, int maxLength)
    {
        if (string.IsNullOrEmpty(input) || input.Length <= maxLength)
            return input;

        return input.Substring(0, maxLength) + "...";
    }
}
