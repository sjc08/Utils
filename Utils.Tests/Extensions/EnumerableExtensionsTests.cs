using Asjc.Utils.Extensions;

namespace Asjc.Utils.Tests.Extensions
{
    [TestClass]
    public class EnumerableExtensionsTests
    {
        [TestMethod]
        public void ContentEqual_TwoSequencesWithSameContent_ReturnsTrue()
        {
            int[] arr1 = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
            int[] arr2 = [1, 3, 5, 7, 9, 0, 2, 4, 6, 8];
            Assert.IsTrue(arr1.ContentEqual(arr2));
        }

        [TestMethod]
        public void ContentEqual_TwoSequencesWithDifferentContent_ReturnsFalse()
        {
            int[] arr1 = [0, 1, 2, 3, 4];
            int[] arr2 = [5, 6, 7, 8, 9];
            Assert.IsFalse(arr1.ContentEqual(arr2));
        }

        [TestMethod]
        public void ContentEqual_TwoSequencesWithDifferentLength_ReturnsFalse()
        {
            int[] arr1 = [0, 1, 2];
            int[] arr2 = [0, 1, 2, 3];
            Assert.IsFalse(arr1.ContentEqual(arr2));
        }

        [TestMethod]
        public void HasDuplicates_SequenceWithDuplicates_ReturnsTrue()
        {
            int[] arr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
            Assert.IsTrue(arr.HasDuplicates());
        }

        [TestMethod]
        public void HasDuplicates_SequenceWithoutDuplicates_ReturnsFalse()
        {
            int[] arr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
            Assert.IsFalse(arr.HasDuplicates());
        }
    }
}