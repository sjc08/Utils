using Asjc.Utils.Extensions;

namespace Asjc.Utils.Tests.Extensions
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void Contains_IgnoreCase_ReturnsTrue()
        {
            Assert.IsTrue("abc0ABC".Contains("Abc", true));
        }

        [TestMethod]
        public void Contains_CaseSensitive_ReturnsFalse()
        {
            Assert.IsFalse("abc0ABC".Contains("Abc", false));
        }

        [TestMethod]
        public void Replace_IgnoreCase_ReturnsReplacedString()
        {
            Assert.AreEqual("abc0ABC".Replace("Abc", "1", true), "101");
        }

        [TestMethod]
        public void Replace_CaseSensitive_ReturnsOriginalString()
        {
            Assert.AreEqual("abc0ABC".Replace("Abc", "1", false), "abc0ABC");
        }
    }
}