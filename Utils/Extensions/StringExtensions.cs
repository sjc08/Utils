using System.Text;

namespace Asjc.Utils.Extensions
{
    /// <summary>
    /// Provides some extension methods.
    /// </summary>
    public static class StringExtensions
    {
#if NETSTANDARD2_0 || NET48
        /// <summary>
        /// Returns a value indicating whether a specified string occurs within this string, using the specified comparison rules.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="value">The string to seek.</param>
        /// <param name="comparisonType">One of the enumeration values that specifies the rules to use in the comparison.</param>
        /// <returns><see langword="true"/> if the <paramref name="value"/> parameter occurs within this string, or if <paramref name="value"/> is the empty string (""); otherwise, <see langword="false"/>.</returns>
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

#if NETSTANDARD2_0 || NET48
        /// <summary>
        /// Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string, using the provided comparison type.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="oldValue">The string to be replaced.</param>
        /// <param name="newValue">The string to replace all occurrences of <paramref name="oldValue"/>.</param>
        /// <param name="comparisonType">One of the enumeration values that determines how <paramref name="oldValue"/> is searched within this instance.</param>
        /// <returns>A string that is equivalent to the current string except that all instances of <paramref name="oldValue"/> are replaced with <paramref name="newValue"/>. If <paramref name="oldValue"/> is not found in the current instance, the method returns the current instance unchanged.</returns>
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
