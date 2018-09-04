using System;
using CustomList3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListTest3
{
    [TestClass]
    public class CustomTest
    {
        [TestMethod]
        public void TestMethodAddInt()
        {


            // Arrange
            ListFunctions<int> listFunctions = new ListFunctions<int>();
            int elementToAdd = 6;
            int expected = 8;

            // Act
            listFunctions.AddList(elementToAdd);
            listFunctions.AddList(elementToAdd);
            listFunctions.AddList(elementToAdd);
            listFunctions.AddList(elementToAdd);
            listFunctions.AddList(8);

            int actual = listFunctions.MyArray[4];


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodAddString()
        {
            ListFunctions<string> listFunctions = new ListFunctions<string>();
            string elementToAdd = "Hello.";
            string expected = "Hello.";

            listFunctions.AddList("6");
            listFunctions.AddList("3");
            listFunctions.AddList("4");
            listFunctions.AddList(elementToAdd);
            listFunctions.AddList("8");
            string actual = listFunctions.MyArray[3];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountArrayLength()
        {
            ListFunctions<string> listFunctions = new ListFunctions<string>();
            int expected = 5;

            listFunctions.AddList("6");
            listFunctions.AddList("3");
            listFunctions.AddList("4");
            listFunctions.AddList("6");
            listFunctions.AddList("8");
            int actual = listFunctions.CountArrayLength();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodRemoveIndex()
        {

            ListFunctions<int> listFunctions = new ListFunctions<int>();
            listFunctions.AddList(5);
            listFunctions.AddList(4);
            listFunctions.AddList(6);
            listFunctions.AddList(7);
            listFunctions.AddList(13);
            listFunctions.RemovedList(4);
            //int indexToRemove = listFunctions.MyArray[3];
            int expected = 5;

            int actual = listFunctions.CountArrayLength();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringConverter()
        {
            ListFunctions<int> listFunctions = new ListFunctions<int>();
            string expected = "8";
            listFunctions.AddList(8);

            string actual = listFunctions.ToString();
            Assert.AreEqual(expected, actual);
        }

    }
}
