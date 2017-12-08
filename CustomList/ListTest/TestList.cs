using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;

namespace ListTest
{
    [TestClass]
    public class TestList
    {
        [TestMethod]
        public void CustomList_InstanceList_CreateList()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            //Act
            CustomList<string> listTwo = new CustomList<string>();

            //Assert
            Assert.AreEqual(list, listTwo);
        }

        [TestMethod]
        public void CustomList_AddStringToArray_AddItem()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            //Act
            string test = "string";
            list.AddToArray("string");

            //Assert
            Assert.AreEqual(test, list[0]);
        }

        [TestMethod]
        public void CustomList_AddIntToArray_AddItem()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            int test = 1;
            list.AddToArray(test);

            //Assert
            Assert.AreEqual(test, list[0]);
        }

        [TestMethod]
        public void CustomList_AddCharToArray_AddItem()
        {
            //Arrange
            CustomList<char> list = new CustomList<char>();

            //Act
            char test = 'a';
            list.AddToArray(test);

            //Assert
            Assert.AreEqual(test, list[0]);
        }

        [TestMethod]
        public void CustomList_AddObjectToArray_AddItem()
        {
            //Arrange
            CustomList<object> list = new CustomList<object>();
            Animal dog = new Animal();

            //Act
            object test = dog;
            list.AddToArray(dog);

            //Assert
            Assert.AreEqual(test, list[0]);
        }

        [TestMethod]
        public void CustomList_RemoveStringFromArray_RemoveItem()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            list.AddToArray("test");
            list.AddToArray("test2");
            list.AddToArray("test3");

            //Act
            list.RemoveFromArray("test2");

            string test = "test3";

            //Assert
            Assert.AreEqual(test, list[1]);
        }

        [TestMethod]
        public void CustomList_CountTwo_ReturnCountTwo()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            int expectedCount = 3;
            int listCount;

            //Act
            list.AddToArray("1");
            list.AddToArray("2");
            list.AddToArray("3");

            listCount = list.CountList();

            //Assert
            Assert.AreEqual(expectedCount, listCount);
        }

    }
}
