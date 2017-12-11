using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;

namespace ListTest
{
    [TestClass]
    public class TestList
    {
        [TestMethod]
        public void CustomList_AddStringToArray_AddItem()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            //Act
            string test = "stringtwo";
            list.AddToArray("string");
            list.AddToArray("stringtwo");

            //Assert
            Assert.AreEqual(test, list[1]);
        }

        [TestMethod]
        public void CustomList_AddFiveStringToArray_AddItem()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            //Act
            string test = "stringfive";

            list.AddToArray("stringone");
            list.AddToArray("stringtwo");
            list.AddToArray("stringthree");
            list.AddToArray("stringfour");
            list.AddToArray("stringfive");

            //Assert
            Assert.AreEqual(test, list[4]);
        }

        [TestMethod]
        public void CustomList_AddFiveIntToArray_AddItem()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            int test = 4;

            list.AddToArray(1);
            list.AddToArray(2);
            list.AddToArray(3);
            list.AddToArray(4);
            list.AddToArray(5);

            //Assert
            Assert.AreEqual(test, list[3]);
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
            string test = "test3";
            list.AddToArray("test");
            list.AddToArray("test2");
            list.AddToArray("test3");

            //Act
            list.RemoveFromArray("test2");

            //Assert
            Assert.AreEqual(test, list[1]);
        }

        [TestMethod]
        public void CustomList_CountFour_ReturnCountFour()
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

        [TestMethod]
        public void CustomList_StringToString_ReturnString()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string test = "string";
            string listString;

            //Act
            list.AddToArray(test);
            listString = list.ToString();

            //Assert
            Assert.AreEqual(test, listString);
        }

        [TestMethod]
        public void CustomList_IntToString_ReturnString()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int test = 1;
            string testResult = "1";
            string listString;

            //Act
            list.AddToArray(test);
            listString = list.ToString();

            //Assert
            Assert.AreEqual(testResult, listString);
        }

        [TestMethod]
        public void CustomList_AddOperator_ReturnList()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            int expectedResult = 10;
            int one = 2;
            int two = 3;
            int three = 1;
            int four = 4;

            //Act
            list1.AddToArray(one);
            list1.AddToArray(two);
            list2.AddToArray(three);
            list2.AddToArray(four);

            list3 = list1 + list2;

            //Assert
            Assert.AreEqual(expectedResult, list3[0]);
        }

        [TestMethod]
        public void CustomList_SubtractOperator_ReturnList()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            int expectedResult = 1;
            int one = 2; //2
            int two = 3; //3
            int three = 1; //1
            int four = 4; //4

            //Act
            list1.AddToArray(one);
            list1.AddToArray(two);
            list2.AddToArray(three);
            list2.AddToArray(four);

            list3 = list1 - list2;

            //Assert
            Assert.AreEqual(expectedResult, list3[0]);
        }

        [TestMethod]
        public void CustomList_ZipInt_ReturnZip()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            int expectedResult = 2;
            int one = 0;
            int two = 1;
            int three = 2;
            int four = 3;

            //Act
            list1.AddToArray(one);
            list1.AddToArray(three);
            list2.AddToArray(two);
            list2.AddToArray(four);

            list3 = list1.Zip(list1, list2);

            //Assert
            Assert.AreEqual(expectedResult, list3[2]);
        }

        [TestMethod]
        public void CustomList_ZipString_ReturnZip()
        {
            //Arrange
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> list3 = new CustomList<string>();
            string expectedResult = "name";
            string one = "my";
            string two = "name";
            string three = "is";
            string four = "chez";

            //Act
            list1.AddToArray(one);
            list1.AddToArray(three);
            list2.AddToArray(two);
            list2.AddToArray(four);

            list3 = list1.Zip(list1, list2);

            //Assert
            Assert.AreEqual(expectedResult, list3[1]);
        }
    }
}
