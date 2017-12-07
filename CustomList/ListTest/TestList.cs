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

        public void CustomList_AddToArray_AddItem()
        {
            //Arrange

            //Act

            //Assert

        }

        [TestMethod]
        public void CustomList_CheckArrayCapacity_IncreaseArrayCapacity()
        {
            //Arrange
            CustomList customlist = new CustomList();
            customlist.BuildArray();

            //Act


            //Assert

        }

        public void CustomList_CountArray_TwoItems()
        {
            //Arrange
            string[] array = new string[2] { "one", "" };
            int arrayCount;

            //Act
            array.Count();
            arrayCount = array.Count();
            
            //Assert
            Assert.AreEqual(array, 2);
        }

        public void CustomList_CapacityArray_OneHigher()
        {
            //Arrange
            string[] array = new string[2] { "", "" };

            //Act
            array.Count();

            //Assert
            Assert.AreEqual()
        }

        [TestMethod]
        public void CustomList_ExpandArray_IncreaseArray()
        {
            //Arrange
            string[] arrayOne = new string[0];
            string[] arrayTwo = new string[1];
            string[] arrayThree = new string[2];

            //Act

            //Assert

        }

        [TestMethod]
        public void CustomList_AddSecondItemToIndex_IncreaseIndex()
        {
            //Arrange
            CustomList customlist = new CustomList();
            string stringValue = "string";
            string[] index = new string[2];

            //Act
            index[0] = "first";
            index[1] = stringValue;

            //Assert
            Assert.AreEqual(index[1], "string");
        }
    }
}
