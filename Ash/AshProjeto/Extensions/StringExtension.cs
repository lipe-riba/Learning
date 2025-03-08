namespace AshProjeto
{
    internal static class StringExtension
    {
        public static bool IsEmpty(this string s)
        {
            return string.IsNullOrEmpty(s) && string.IsNullOrWhiteSpace(s);
        }
    }
}
