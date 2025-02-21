using Asjc.Utils.Extensions;

namespace Asjc.Utils.Tests.Extensions
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void ConvertToTest1()
        {
            Assert.AreEqual("1".ChangeType(typeof(int)), 1);
        }

        [TestMethod]
        public void ConvertToTest2()
        {
            Assert.IsFalse("A".TryChangeType(typeof(int), out var result));
            Assert.AreEqual(result, null);
        }

        [TestMethod]
        public void ConvertToTest3()
        {
            object? obj = null;
            Assert.IsFalse(obj.TryChangeType(typeof(int), out var result));
            Assert.AreEqual(result, null);
        }

        [TestMethod]
        public void ConvertToTest4()
        {
            object? obj = null;
            Assert.IsTrue(obj.TryChangeType(typeof(string), out var result));
            Assert.AreEqual(result, null);
        }
    }
}