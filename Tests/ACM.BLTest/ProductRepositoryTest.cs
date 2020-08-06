using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Tulipa",
                ProductName = "Flores"
            };

            //actual
            var actual = productRepository.Retrieve(2);

            //assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }

        [TestMethod]
        public void SaveTestvalid()
        {
            //arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "LOL",
                ProductName ="TP",
                HasChanges = true
            };

            //actual
            var actual = productRepository.Save(updatedProduct);

            //assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductDescription = "LOL",
                ProductName = "TP",
                HasChanges = true
            };

            //actual
            var actual = productRepository.Save(updatedProduct);

            //assert
            Assert.AreEqual(false, actual);
        }
    }
}
