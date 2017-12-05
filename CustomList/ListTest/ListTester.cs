using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;

namespace ListTest
{
    [TestClass]
    public class ListTester
    {
        [TestMethod]
        public void CustomList_Increment_IncreaseListCount()
        {
            //Arrange
            CustomList customlist = new CustomList();
            int listValue = 0;
            int addValue = 1;

            //Act
            listValue = listValue + addValue;

            //Assert
            Assert.AreEqual(listValue, 1);
        }

        [TestMethod]
        public void CustomList_Decrement_DecreaseListCount()
        {
            //Arrange
            CustomList customList = new CustomList();
            int listValue = 0;
            int decreaseValue = -1;

            //Act
            listValue = listValue + decreaseValue;

            //Assert
            Assert.AreNotEqual(listValue, 1);
        }

        [TestMethod]
        public void CustomList_IncreaseListCount_IncreaseOverallListValue()
        {
            //Arrange
            CustomList customlist = new CustomList();
            int listValue = Int32.MaxValue;

            //Act
            for (int i = Int32.MaxValue; i < listValue; i++)
            {
                listValue += Int32.MaxValue;
            }

            //Assert
            Assert.AreEqual(listValue, Int32.MaxValue);
        }

        [TestMethod]
        public void CustomList_DecreaseListCount_DecreaseOverallListValue()
        {
            //Arrange
            CustomList customlist = new CustomList();
            int listValue = Int32.MaxValue;

            //Act
            for (int i = Int32.MaxValue; i < listValue; i--)
            {
                listValue += Int32.MaxValue;
            }

            //Assert
            Assert.AreEqual(listValue, Int32.MaxValue);
        }
    }
}
