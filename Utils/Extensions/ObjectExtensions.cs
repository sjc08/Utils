using static Asjc.Utils.Tryer;

namespace Asjc.Utils.Extensions
{
    /// <summary>
    /// Provides some extension methods.
    /// </summary>
    public static class ObjectExtensions
    {
        public static object? ChangeType(this object? value, Type conversionType)
            => Convert.ChangeType(value, conversionType);

        public static object? ChangeType(this object? value, TypeCode typeCode)
            => Convert.ChangeType(value, typeCode);

        public static object? ChangeType(this object? value, Type conversionType, IFormatProvider? provider)
            => Convert.ChangeType(value, conversionType, provider);

        public static object? ChangeType(this object? value, TypeCode typeCode, IFormatProvider? provider)
            => Convert.ChangeType(value, typeCode, provider);

        public static bool TryChangeType(this object? value, Type conversionType, out object? result)
            => Try(() => value.ChangeType(conversionType), out result);

        public static bool TryChangeType(this object? value, TypeCode typeCode, out object? result)
            => Try(() => value.ChangeType(typeCode), out result);

        public static bool TryChangeType(this object? value, Type conversionType, IFormatProvider? provider, out object? result)
           => Try(() => value.ChangeType(conversionType, provider), out result);

        public static bool TryChangeType(this object? value, TypeCode typeCode, IFormatProvider? provider, out object? result)
            => Try(() => value.ChangeType(typeCode, provider), out result);

        public static object? TryChangeType(this object? value, Type conversionType)
            => Try(() => value.ChangeType(conversionType));

        public static object? TryChangeType(this object? value, TypeCode typeCode)
            => Try(() => value.ChangeType(typeCode));

        public static object? TryChangeType(this object? value, Type conversionType, IFormatProvider? provider)
            => Try(() => value.ChangeType(conversionType, provider));

        public static object? TryChangeType(this object? value, TypeCode typeCode, IFormatProvider? provider)
            => Try(() => value.ChangeType(typeCode, provider));
    }
}
