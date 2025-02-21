namespace Asjc.Utils.Extensions
{
    /// <summary>
    /// Provides some extension methods.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Determines whether two sequences have the same content by using the default equality comparer for their type. The order will be ignored.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
        /// <param name="first">An <see cref="IEnumerable{T}"/> to compare to <paramref name="second"/>.</param>
        /// <param name="second">An <see cref="IEnumerable{T}"/> to compare to <paramref name="first"/>.</param>
        /// <returns><see langword="true"/> if the two source sequences are of equal length and their contents are equal according to the default equality comparer for their type; otherwise, <see langword="false"/>.</returns>
        public static bool ContentEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            if (first == second)
                return true;
            if (first.Count() != second.Count())
                return false;
            return first.OrderBy(x => x).SequenceEqual(second.OrderBy(x => x));
        }

        /// <summary>
        /// Determines whether two sequences have the same content by using a specified <see cref="IEqualityComparer{T}"/>. The order will be ignored.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
        /// <param name="first">An <see cref="IEnumerable{T}"/> to compare to <paramref name="second"/>.</param>
        /// <param name="second">An <see cref="IEnumerable{T}"/> to compare to <paramref name="first"/>.</param>
        /// <param name="comparer">An <see cref="IEqualityComparer{T}"/> to use to compare elements.</param>
        /// <returns><see langword="true"/> if the two source sequences are of equal length and their contents are equal according to <paramref name="comparer"/>; otherwise, <see langword="false"/>.</returns>
        public static bool ContentEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource>? comparer)
        {
            if (first == second)
                return true;
            if (first.Count() != second.Count())
                return false;
            return first.OrderBy(x => x).SequenceEqual(second.OrderBy(x => x), comparer);
        }

        /// <summary>
        /// Checks if a sequence contains duplicate values.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">Source sequence.</param>
        /// <returns><see langword="true"/> if any element of the sequence is duplicated; otherwise, <see langword="false"/>.</returns>
        public static bool HasDuplicates<TSource>(this IEnumerable<TSource> source)
        {
            var set = new HashSet<TSource>();
            foreach (TSource item in source)
            {
                if (!set.Add(item))
                    return true;
            }
            return false;
        }
    }
}
