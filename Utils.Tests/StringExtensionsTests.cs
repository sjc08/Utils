namespace Asjc.Utils.Extensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void ReplaceTest() => Assert.AreEqual("Abc0ABc".Replace("ABC", "1", true), "101");
    }
}