using Asjc.Utils.Extensions;

namespace Asjc.Utils.Tests.Extensions
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void ReplaceTest() => Assert.AreEqual("Abc0ABc".Replace("ABC", "1", true), "101");
    }
}