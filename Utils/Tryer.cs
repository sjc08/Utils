using System.Diagnostics.CodeAnalysis;

namespace Asjc.Utils
{
    public static class Tryer
    {
        /// <summary>
        /// Trys to execute <paramref name="action"/>.
        /// </summary>
        /// <param name="action">The delegate to be executed.</param>
        /// <returns>A <see langword="bool"/> indicating whether no exception has occurred.</returns>
        public static bool Try(Action action)
        {
            try
            {
                action();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Trys to execute <paramref name="func"/>.
        /// </summary>
        /// <typeparam name="T">The type of the return value of <paramref name="func"/>.</typeparam>
        /// <param name="func">The delegate to be executed.</param>
        /// <returns>The return value of <paramref name="func"/> if no exception has occurred; otherwise, <see langword="default"/>.</returns>
        public static T? Try<T>(Func<T> func)
        {
            try
            {
                return func();
            }
            catch
            {
                return default;
            }
        }

        /// <summary>
        /// Trys to execute <paramref name="func"/>.
        /// </summary>
        /// <typeparam name="T">The type of the return value of <paramref name="func"/>.</typeparam>
        /// <param name="func">The delegate to be executed.</param>
        /// <param name="result">The return value of <paramref name="func"/> if no exception has occurred; otherwise, <see langword="default"/>.</param>
        /// <returns>A <see langword="bool"/> indicating whether no exception has occurred.</returns>
#if NETSTANDARD2_1 || NET8_0
        public static bool Try<T>(Func<T> func, [MaybeNullWhen(false)] out T result)
#else
        public static bool Try<T>(Func<T> func, out T? result)
#endif
        {
            try
            {
                result = func();
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }
    }
}
