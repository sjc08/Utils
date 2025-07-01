using Asjc.Utils.Extensions;

namespace Asjc.Utils.Tests.Extensions
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void ChangeType_StringToInt_ReturnsConvertedValue()
        {
            Assert.AreEqual("1".ChangeType(typeof(int)), 1);
        }

        [TestMethod]
        public void ChangeType_NullToString_ReturnsNull()
        {
            object? obj = null;
            Assert.AreEqual(obj.ChangeType(typeof(string)), null);
        }

        [TestMethod]
        public void TryChangeType_InvalidConversion_ReturnsFalseAndNull()
        {
            Assert.IsFalse("A".TryChangeType(typeof(int), out var result));
            Assert.AreEqual(result, null);
        }

        [TestMethod]
        public void TryChangeType_NullToInt_ReturnsFalseAndNull()
        {
            object? obj = null;
            Assert.IsFalse(obj.TryChangeType(typeof(int), out var result));
            Assert.AreEqual(result, null);
        }

        [TestMethod]
        public void TryChangeType_NullToString_ReturnsTrueAndNull()
        {
            object? obj = null;
            Assert.IsTrue(obj.TryChangeType(typeof(string), out var result));
            Assert.AreEqual(result, null);
        }
    }
}