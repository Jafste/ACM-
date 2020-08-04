using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                EmailAdress = "fb@gmail.com",
                FirstName = "Marcos",
                LastName = "Monteiro"
            };

            //act
            var actual = customerRepository.Retrieve(1);

            //assert
          

        }
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAdress = "fb@gmail.com",
                FirstName = "Marcos",
                LastName = "Monteiro",
                AddressList = new List<Address>()
                    {
                        new Address()
                        {
                            AddressType = 1,
                            StreetLine1 = "bag",
                            StreetLine2 = "row",
                            City = "hob",
                            State = "aveiro",
                            Country = "Portugal",
                            PostalCode = "144"
                        },
                        new Address()
                        {
                            AddressType = 1,
                            StreetLine1 = "2",
                            StreetLine2 = "2",
                            City = "2",
                            State = "2",
                            Country = "Portugal",
                            PostalCode = "145",
                        }

                    }
            };

            //act
            var actual = customerRepository.Retrieve(1);

            //assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
