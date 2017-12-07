using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;

namespace ListTest
{
    [TestClass]
    public class TestList
    {
        [TestMethod]
        public void CustomList_InstanceStringList_CreateList()
        {
            //Arrange
            CustomList customlist = new CustomList();
            customlist.BuildArray();

            //Act
            string[] array = new string[0];

            //Assert
            Assert.AreEqual(array, "string");
        }

        [TestMethod]
        public void CustomList_CountArray_TwoItems()
        {
            //Arrange
            string[] array = new string[2] { "one", "" };

            //Act
            array.Count()
            
            //Assert
            Assert.AreEqual(array, 2);
        }

        [TestMethod]
        public void CustomList_AddToArray_IncreaseArray()
        {
            //Arrange

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
