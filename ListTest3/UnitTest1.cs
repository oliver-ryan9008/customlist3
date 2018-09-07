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
            int expected = 6579;

            // Act
            listFunctions.AddList(elementToAdd);
            listFunctions.AddList(elementToAdd);
            listFunctions.AddList(elementToAdd);
            listFunctions.AddList(elementToAdd);
            listFunctions.AddList(8);
            listFunctions.AddList(09812537);
            listFunctions.AddList(893475);
            listFunctions.AddList(57);
            listFunctions.AddList(63);
            listFunctions.AddList(87);
            listFunctions.AddList(353);
            listFunctions.AddList(657);
            listFunctions.AddList(516);
            listFunctions.AddList(687);
            listFunctions.AddList(498);
            listFunctions.AddList(6579);
            listFunctions.AddList(634357354);

            int actual = listFunctions.MyArray[15];


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

        [TestMethod]
        public void TestIndexerForString()
        {
            ListFunctions<string> listFunctions = new ListFunctions<string>();

            string expected = "World";

            listFunctions.AddList("Hello");
            listFunctions.AddList("World");
            listFunctions.AddList("!");

            string actual = listFunctions[1];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIndexerForInt()
        {
            ListFunctions<int> listFunctions = new ListFunctions<int>();

            int expected = 37;

            listFunctions.AddList(1);
            listFunctions.AddList(54);
            listFunctions.AddList(37);
            listFunctions.AddList(82759291);

            int actual = listFunctions[2];
            Assert.AreEqual(expected, actual);
        }

    }
}
