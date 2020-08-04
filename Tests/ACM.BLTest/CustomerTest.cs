using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            var expected = "Baggins, Bilbo";

            //Actar
            var actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            var expected = "Baggins";

            //Actar
            var actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            var expected = "Bilbo";

            //Actar
            var actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer
            {
                FirstName = "Bilbo"
            };

            Customer.InstanceCount += 1;

            var cc2 = new Customer
            {
                FirstName = "Frodo"
            };

            Customer.InstanceCount += 1;

            var c3 = new Customer
            {
                FirstName = "Rosie"
            };

            Customer.InstanceCount += 1;

            //Actar
            var actual = Customer.InstanceCount;

            //assert
            Assert.AreEqual(3, actual);

        }

        [TestMethod]
        public void ValidadeValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Bilbo",
                EmailAdress = "fbaggins@hobbiton.me"
            };
            var expected = true;

            //Actar
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidadeMissingLastName()
        {
            // Arrange
            Customer customer = new Customer
            {
                EmailAdress = "fbaggins@hobbiton.me"
            };
            var expected = false;

            //Actar
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
