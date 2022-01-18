using LibraryLists;
using NUnit.Framework;
using System;

namespace TestProject1
{
    [TestFixture(typeof(ArrayList<int>))]
    public class Tests<T> where T : IList<int>, new()
    {
        IList<int> _list;

        [SetUp]
        public void Setup()
        {
            _list = new T();
        }

        [Test]
        public void Add_WhenCalled_ShouldAddElementToZeroIndex()
        {
            _list.Add(10);
            _list.Add(102);

            Assert.AreEqual(10, _list[0]);
            Assert.AreEqual(102, _list[1]);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
        public void InitializerForArray_WhenArrayPassed_ShouldFillList
            (int[] sourceArray, int[] expectedArray)
        {
            _list = (LibraryLists.IList<int>)Activator.CreateInstance(typeof(T), sourceArray);
            var instance = _list.CreateInstance(sourceArray);

            CollectionAssert.AreEqual(expectedArray, instance);
        }

        //[TestCase(new int[] { 1, 7, 3, 3 }, new int[] { 1, 3, 3, 7 })]
        //[TestCase(new int[] { 2, 1, 4 }, new int[] {2, 1, 5})]
        //[TestCase(new int[] { 2, 4, 1, 3, 2 }, new int[] { 2, 4, 1, 3, 2 })]
        //public void SortArrayByInsertMethod_WhenArrayNotNull_ShouldSortArrayByInsertMethod(
        //    int[] sourceArray,
        //    int[] expectedArray)
        //{
        //    _list.Sort();

        //    Assert.AreEqual(sourceArray, expectedArray);
        //}

        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3)]
        public void IndexerGet_WhenValidIndexByValue_ShouldReturnElementIndex()
        {
            _list.Add(10);
            _list.Add(102);

            Assert.AreEqual(10, _list[0]);
            Assert.AreEqual(102, _list[1]);
        }
    }
}