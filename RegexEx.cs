using System.Text.RegularExpressions;

public static class RegexEx
{
    public static bool IsValid(string pattern)
    {
        try
        {
            Regex.IsMatch(String.Empty, pattern);
            return true;
        }
        catch
        {
            return false;
        }
    } 
}