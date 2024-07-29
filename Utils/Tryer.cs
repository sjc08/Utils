using System.Diagnostics.CodeAnalysis;

namespace Asjc.Utils
{
    public static class Tryer
    {
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
