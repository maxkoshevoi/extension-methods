public static class StringEx
{
    public static string ToTitleCase(this string str) => System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
}
