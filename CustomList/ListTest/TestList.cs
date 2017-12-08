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
            string[] array = new string[0];

            //Assert
            Assert.AreEqual(array, "empty");
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
        public void CustomList_CheckArrayCapacity_IncreaseArrayCapacity()
        {
            //Arrange
            

            //Act


            //Assert

        }
    }
}
