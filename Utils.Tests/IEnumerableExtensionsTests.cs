namespace Asjc.Utils.Extensions.Tests
{
    [TestClass]
    public class IEnumerableExtensionsTests
    {
        [TestMethod]
        public void ContentEqualTest()
        {
            int[] arr1 = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
            int[] arr2 = [2, 3, 5, 7, 1, 9, 8, 6, 4, 0];
            Assert.IsTrue(arr1.ContentEqual(arr2));
        }

        [TestMethod]
        public void HasDuplicatesTest()
        {
            int[] arr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
            Assert.IsTrue(arr.HasDuplicates());
        }
    }
}