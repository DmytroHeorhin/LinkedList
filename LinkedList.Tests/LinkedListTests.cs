using System;
using System.Collections.Generic;
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
        public void ElementAt_IndexIsGreaterThenLastElementIndex_ShouldThrowIndexOutOfRange()
        {
            var sut = new LinkedList<string> {"test1", "test2"};
            Exception exception = null;

            try
            {
                sut.ElementAt(2);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsInstanceOfType(exception, typeof(IndexOutOfRangeException));
        }

        [TestMethod]
        public void ElementAt_IndexIsLessThenZero_ShouldThrowIndexOutOfRange()
        {
            var sut = new LinkedList<string> { "test1", "test2" };
            Exception exception = null;

            try
            {
                sut.ElementAt(-1);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsInstanceOfType(exception, typeof(IndexOutOfRangeException));
        }

        [TestMethod]
        public void ElementAt_IndexIsValid_ShouldReturnItemfromSpecifiedPosition()
        {
            var item = "test";
            var sut = new LinkedList<string> { "test1", "test2", item };

            var result = sut.ElementAt(2);

            Assert.AreEqual(item, result);
        }

        [TestMethod]
        public void AddAt_IndexIsGreaterThenLastElementIndex_ShouldThrowIndexOutOfRange()
        {
            var sut = new LinkedList<string> { "test1", "test2" };
            Exception exception = null;

            try
            {
                sut.AddAt("test", 2);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsInstanceOfType(exception, typeof(IndexOutOfRangeException));
        }

        [TestMethod]
        public void AddAt_IndexIsLessThenZero_ShouldThrowIndexOutOfRange()
        {
            var sut = new LinkedList<string> { "test1", "test2" };
            Exception exception = null;

            try
            {
                sut.AddAt("test", -1);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsInstanceOfType(exception, typeof(IndexOutOfRangeException));
        }

        [TestMethod]
        public void AddAt_IndexisValid_ShouldIncreaseLengthAndStoreItemInTheSpecifiedPosition()
        {
            var sut = new LinkedList<string> { "test1", "test2", "test3", "test4" };
            var item = "test";

            var result = sut.AddAt(item, 2);

            Assert.AreEqual(5, sut.Length);
            Assert.AreEqual(item, sut.ElementAt(2));
            Assert.AreEqual(item, result);
        }

        [TestMethod]
        public void RemoveAt_IndexIsGreaterThenLastElementIndex_ShouldThrowIndexOutOfRange()
        {
            var sut = new LinkedList<string> { "test1", "test2" };

            var result = sut.RemoveAt(2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RemoveAt_IndexIsLessThenZero_ShouldThrowIndexOutOfRange()
        {
            var sut = new LinkedList<string> { "test1", "test2" };
            Exception exception = null;

            try
            {
                sut.RemoveAt(-1);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsInstanceOfType(exception, typeof(IndexOutOfRangeException));
        }

        [TestMethod]
        public void RemoveAt_IndexIsValid_ShouldDecreaseLengthAndDeleteItemfromTheSpecifiedPosition()
        {
            var item = "test";
            var sut = new LinkedList<string> { "test1", "test2", item, "test3", "test4" };
            
            var result = sut.RemoveAt(1);

            Assert.AreEqual(4, sut.Length);
            Assert.AreEqual(item, sut.ElementAt(1));
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetEnumerator_UsedInForeachLoop_ShouldReturnSequenceOfItems()
        {
            var list = new List<int> {1, 2, 3, 4};
            var sut = new LinkedList<int>(list);
            var result = new List<int>();

            foreach (var item in sut)
            {
                result.Add(item);
            }

            CollectionAssert.AreEqual(list, result);
        }
    }
}
