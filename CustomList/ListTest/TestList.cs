using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;

namespace ListTest
{
    [TestClass]
    public class TestList
    {
        [TestMethod]
        public void CustomList_Increment_IncreaseListCount()
        {
            //Arrange
            CustomList customlist = new CustomList();
            int listValue = 0;
            int addValue = 1;

            //Act
            listValue += addValue;

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
            listValue += decreaseValue;

            //Assert
            Assert.AreNotEqual(listValue, 1);
        }

        [TestMethod]
        public void CustomList_Decrement_ListEqualsZero()
        {
            //Arrange
            CustomList customList = new CustomList();
            int listValue = 1;
            int decreaseValue = -1;

            //Act
            listValue += decreaseValue;

            //Assert
            Assert.AreEqual(listValue, 0);
        }

        [TestMethod]
        public void CustomList_AddString_IncreaseIndex()
        {
            //Arrange
            CustomList customlist = new CustomList();
            string stringValue = "string";
            string[] index = new string[1];

            //Act
            index[0] += stringValue;

            //Assert
            Assert.AreEqual(index[0], "string");
        }

        [TestMethod]
        public void CustomList_AddInt_IncreaseIndex()
        {
            //Arrange
            CustomList customlist = new CustomList();
            int intValue = 0;
            int[] index = new int[1];

            //Act
            index[0] += intValue;

            //Assert
            Assert.AreEqual(index[0], 0);
        }

        //[TestMethod]
        //public void CustomList_AddChar_IncreaseIndex()
        //{
        //    //Arrange
        //    CustomList customlist = new CustomList();
        //    char;
        //    string[] index = new string[1];

        //    //Act
        //    index[0] = char;

        //    //Assert

        //}

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

        //[TestMethod]
        //public void CustomList_AddIndexToIndex_ExpandIndex()
        //{
        //    //Arrange
        //    CustomList customList = new CustomList();
        //    string[] indexOne = new string[0];
        //    string[] indexTwo = new string[1];

        //    //Act
        //    indexTwo[0] += indexOne[0];

        //    for(int = indexOne; int < indexTwo; i++)
        //    {
        //        indexOne++;
        //    }

        //    //Assert
        //    Assert.AreEqual(indexTwo[0], indexOne[0]);
        //}
    }
}
