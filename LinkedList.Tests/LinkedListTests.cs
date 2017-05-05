using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void Add_ShouldIncreaseLengthAndStoreItemInTheEnd()
        {
            var sut = new LinkedList<string>();
            var item = "test";

            var result = sut.Add(item);

            Assert.AreEqual(1, sut.Length);
            Assert.AreEqual(item, sut.ElementAt(0));
            Assert.AreEqual(item, result);
        }

        [TestMethod]
        public void Remove_ShouldDecreaseLengthAndReturnTrue()
        {
            var sut = new LinkedList<string> {"test1", "test2"};

            var result = sut.Remove();

            Assert.AreEqual(1, sut.Length);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ElementAt_IndexIsGreaterThenLength_ShouldThrowIndexOutOfRange()
        {
            var sut = new LinkedList<string> {"test1", "test2"};

            try
            {
                sut.ElementAt(2);
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(IndexOutOfRangeException));
            }        
        }
    }
}
