using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LogginServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAdress ="@gmail.com",
                FirstName="Marcos",
                LastName="Monteiro",
                AddressList= null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "flor",
                ProductDescription = "Tulipa",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            //act
            LogginService.WriteToFle(changedItems);
             
            //assert
           
        }
    }
}
