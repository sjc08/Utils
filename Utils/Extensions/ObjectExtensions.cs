using System.Diagnostics.CodeAnalysis;
using static Asjc.Utils.Tryer;

namespace Asjc.Utils.Extensions
{
    /// <summary>
    /// Provides some extension methods.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Returns an object of the specified type whose value is equivalent to the specified object.
        /// </summary>
        /// <param name="value">An object that implements the <see cref="IConvertible"/> interface.</param>
        /// <param name="conversionType">The type of object to return.</param>
        /// <returns>An object whose type is <paramref name="conversionType"/> and whose value is equivalent to <paramref name="value"/>. -or- A null reference (Nothing in Visual Basic), if <paramref name="value"/> is <see langword="null"/> and <paramref name="conversionType"/> is not a value type.</returns>
        public static object? ChangeType(this object? value, Type conversionType)
            => Convert.ChangeType(value, conversionType);

        /// <summary>
        /// Returns an object of the specified type whose value is equivalent to the specified object.
        /// </summary>
        /// <param name="value">An object that implements the <see cref="IConvertible"/> interface.</param>
        /// <param name="typeCode">The type of object to return.</param>
        /// <returns>An object whose underlying type is <paramref name="typeCode"/> and whose value is equivalent to <paramref name="value"/>. -or- A null reference (Nothing in Visual Basic), if <paramref name="value"/> is <see langword="null"/> and <paramref name="typeCode"/> is <see cref="TypeCode.Empty"/>, <see cref="TypeCode.String"/>, or <see cref="TypeCode.Object"/>.</returns>
        public static object? ChangeType(this object? value, TypeCode typeCode)
            => Convert.ChangeType(value, typeCode);

        /// <summary>
        /// Returns an object of the specified type whose value is equivalent to the specified object. A parameter supplies culture-specific formatting information.
        /// </summary>
        /// <param name="value">An object that implements the <see cref="IConvertible"/> interface.</param>
        /// <param name="conversionType">The type of object to return.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>An object whose type is <paramref name="conversionType"/> and whose value is equivalent to <paramref name="value"/>. -or- <paramref name="value"/>, if the <see cref="Type"/> of value and <paramref name="conversionType"/> are equal. -or- A null reference (Nothing in Visual Basic), if <paramref name="value"/> is <see langword="null"/> and <paramref name="conversionType"/> is not a value type.</returns>
        public static object? ChangeType(this object? value, Type conversionType, IFormatProvider? provider)
            => Convert.ChangeType(value, conversionType, provider);

        /// <summary>
        /// Returns an object of the specified type whose value is equivalent to the specified object. A parameter supplies culture-specific formatting information.
        /// </summary>
        /// <param name="value">An object that implements the <see cref="IConvertible"/> interface.</param>
        /// <param name="typeCode">The type of object to return.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>An object whose underlying type is <paramref name="typeCode"/> and whose value is equivalent to <paramref name="value"/>. -or- A null reference (Nothing in Visual Basic), if <paramref name="value"/> is <see langword="null"/> and <paramref name="typeCode"/> is <see cref="TypeCode.Empty"/>, <see cref="TypeCode.String"/>, or <see cref="TypeCode.Object"/>.</returns>
        public static object? ChangeType(this object? value, TypeCode typeCode, IFormatProvider? provider)
            => Convert.ChangeType(value, typeCode, provider);

        public static object? TryChangeType(this object? value, Type conversionType)
            => Try(() => value.ChangeType(conversionType));

        public static object? TryChangeType(this object? value, TypeCode typeCode)
            => Try(() => value.ChangeType(typeCode));

        public static object? TryChangeType(this object? value, Type conversionType, IFormatProvider? provider)
            => Try(() => value.ChangeType(conversionType, provider));

        public static object? TryChangeType(this object? value, TypeCode typeCode, IFormatProvider? provider)
            => Try(() => value.ChangeType(typeCode, provider));

#if NETSTANDARD2_1 || NET8_0
        public static bool TryChangeType(this object? value, Type conversionType, [MaybeNullWhen(false)] out object result)
#else
        public static bool TryChangeType(this object? value, Type conversionType, out object? result)
#endif
            => Try(() => value.ChangeType(conversionType), out result);

#if NETSTANDARD2_1 || NET8_0
        public static bool TryChangeType(this object? value, TypeCode typeCode, [MaybeNullWhen(false)] out object result)
#else
        public static bool TryChangeType(this object? value, TypeCode typeCode, out object? result)
#endif
            => Try(() => value.ChangeType(typeCode), out result);

#if NETSTANDARD2_1 || NET8_0
        public static bool TryChangeType(this object? value, Type conversionType, IFormatProvider? provider, [MaybeNullWhen(false)] out object result)
#else
        public static bool TryChangeType(this object? value, Type conversionType, IFormatProvider? provider, out object? result)
#endif
            => Try(() => value.ChangeType(conversionType, provider), out result);

#if NETSTANDARD2_1 || NET8_0
        public static bool TryChangeType(this object? value, TypeCode typeCode, IFormatProvider? provider, [MaybeNullWhen(false)] out object result)
#else
        public static bool TryChangeType(this object? value, TypeCode typeCode, IFormatProvider? provider, out object? result)
#endif
            => Try(() => value.ChangeType(typeCode, provider), out result);
    }
}
