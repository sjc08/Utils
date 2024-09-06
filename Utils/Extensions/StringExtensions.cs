using System.Text;

namespace Asjc.Utils.Extensions
{
    /// <summary>
    /// Provides some extension methods.
    /// </summary>
    public static class StringExtensions
    {
#if NETSTANDARD2_0 || NET472
        public static bool Contains(this string str, string value, StringComparison comparisonType)
        {
            return str.IndexOf(value, comparisonType) >= 0;
        }
#endif

        public static bool Contains(this string str, string value, bool ignoreCase)
        {
            return str.Contains(value, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
        }

        public static bool Equals(this string str, string? value, bool ignoreCase)
        {
            return str.Equals(value, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
        }

        public static string Replace(this string str, string oldValue, string? newValue, bool ignoreCase)
        {
            return str.Replace(oldValue, newValue, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
        }

#if NETSTANDARD2_0 || NET472
        public static string Replace(this string str, string oldValue, string? newValue, StringComparison comparisonType)
        {
            StringBuilder sb = new();

            int previousIndex = 0;
            int index = str.IndexOf(oldValue, comparisonType);
            while (index != -1)
            {
                sb.Append(str.Substring(previousIndex, index - previousIndex));
                sb.Append(newValue);
                index += oldValue.Length;

                previousIndex = index;
                index = str.IndexOf(oldValue, index, comparisonType);
            }
            sb.Append(str.Substring(previousIndex));

            return sb.ToString();
        }
#endif
    }
}
