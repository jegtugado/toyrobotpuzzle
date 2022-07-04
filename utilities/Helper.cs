public static class Helper
{
    public static bool IsUpper(this string text)
    {
        foreach (char c in text)
            if (Char.IsLetter(c) && !Char.IsUpper(c))
                return false;
        return true;
    }
}