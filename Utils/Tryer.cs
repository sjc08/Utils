using System.Diagnostics.CodeAnalysis;

namespace Asjc.Utils
{
    /// <summary>
    /// Provides a set of static methods for simplifying exception handling.
    /// </summary>
    public static class Tryer
    {
        /// <summary>
        /// Attempts to execute <paramref name="action"/>.
        /// </summary>
        /// <param name="action">The action to execute.</param>
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
        /// Attempts to execute <paramref name="action"/>.
        /// </summary>
        /// <param name="action">The action to execute.</param>
        /// <param name="onError">The callback to invoke when an exception occurs.</param>
        /// <returns>A <see langword="bool"/> indicating whether no exception has occurred.</returns>
        public static bool Try(Action action, Action<Exception> onError)
        {
            try
            {
                action();
                return true;
            }
            catch (Exception e)
            {
                onError(e);
                return false;
            }
        }

        /// <summary>
        /// Attempts to execute <paramref name="func"/>.
        /// </summary>
        /// <typeparam name="T">The type of the return value.</typeparam>
        /// <param name="func">The function to execute.</param>
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
        /// Attempts to execute <paramref name="func"/>.
        /// </summary>
        /// <typeparam name="T">The type of the return value.</typeparam>
        /// <param name="func">The function to execute.</param>
        /// <param name="onError">The callback to invoke when an exception occurs.</param>
        /// <returns>The return value of <paramref name="func"/> if no exception has occurred; otherwise, <see langword="default"/>.</returns>
        public static T? Try<T>(Func<T> func, Action<Exception> onError)
        {
            try
            {
                return func();
            }
            catch (Exception e)
            {
                onError(e);
                return default;
            }
        }

        /// <summary>
        /// Attempts to execute <paramref name="func"/>.
        /// </summary>
        /// <typeparam name="T">The type of the return value.</typeparam>
        /// <param name="func">The function to execute.</param>
        /// <param name="onError">The callback to invoke when an exception occurs.</param>
        /// <returns>The return value of <paramref name="func"/> if no exception has occurred; otherwise, the return value of <paramref name="onError"/>.</returns>
        public static T Try<T>(Func<T> func, Func<Exception, T> onError)
        {
            try
            {
                return func();
            }
            catch (Exception e)
            {
                return onError(e);
            }
        }

        /// <summary>
        /// Attempts to execute <paramref name="func"/>.
        /// </summary>
        /// <typeparam name="T">The type of the return value.</typeparam>
        /// <param name="func">The function to execute.</param>
        /// <param name="result">The return value of <paramref name="func"/> if no exception has occurred; otherwise, <see langword="default"/>.</param>
        /// <returns>A <see langword="bool"/> indicating whether no exception has occurred.</returns>
#if NET8_0 || NETCOREAPP3_1 || NETSTANDARD2_1
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

        /// <summary>
        /// Attempts to execute <paramref name="func"/>.
        /// </summary>
        /// <typeparam name="T">The type of the return value.</typeparam>
        /// <param name="func">The function to execute.</param>
        /// <param name="onError">The callback to invoke when an exception occurs.</param>
        /// <param name="result">The return value of <paramref name="func"/> if no exception has occurred; otherwise, <see langword="default"/>.</param>
        /// <returns>A <see langword="bool"/> indicating whether no exception has occurred.</returns>
#if NET8_0 || NETCOREAPP3_1 || NETSTANDARD2_1
        public static bool Try<T>(Func<T> func, Action<Exception> onError, [MaybeNullWhen(false)] out T result)
#else
        public static bool Try<T>(Func<T> func, Action<Exception> onError, out T? result)
#endif
        {
            try
            {
                result = func();
                return true;
            }
            catch (Exception e)
            {
                onError(e);
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Attempts to execute <paramref name="func"/>.
        /// </summary>
        /// <typeparam name="T">The type of the return value.</typeparam>
        /// <param name="func">The function to execute.</param>
        /// <param name="onError">The callback to invoke when an exception occurs.</param>
        /// <param name="result">The return value of <paramref name="func"/> if no exception has occurred; otherwise, the return value of <paramref name="onError"/>.</param>
        /// <returns>A <see langword="bool"/> indicating whether no exception has occurred.</returns>
        public static bool Try<T>(Func<T> func, Func<Exception, T> onError, out T result)
        {
            try
            {
                result = func();
                return true;
            }
            catch (Exception e)
            {
                result = onError(e);
                return false;
            }
        }
    }
}
