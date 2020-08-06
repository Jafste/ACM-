using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //arrange
            var source = "OlaMarcos";
            var expeted = "Ola Marcos";

            //Act
            var actual = source.InsertSpaces();

            //assert
            Assert.AreEqual(expeted, actual);
        }


        [TestMethod]
        public void InsertSpacesTestExistingSpace()
        {
            //arrange
            var source = "Ola Marcos";
            var expeted = "Ola Marcos";

            //Act
            var actual = source.InsertSpaces();

            //assert
            Assert.AreEqual(expeted, actual);
        }

        [TestMethod]
        public void InsertSpacesTestIsEmptyValid()
        {
            //arrange
            var source = "";
            var expeted = "";

            //Act
            var actual = source.InsertSpaces();

            //assert
            Assert.AreEqual(expeted, actual);
        }

        [TestMethod]
        public void InsertSpacesTestIsNull()
        {
            //arrange
            var expeted = "";

            //Act
            var actual = StringHandler.InsertSpaces(null);

            //assert
            Assert.AreEqual(expeted, actual);
        }
    }
}
