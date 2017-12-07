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
            

            //Act


            //Assert

        }
    }
}
