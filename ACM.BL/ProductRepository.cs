using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        ///<summary>
        ///retrieve one product
        ///</summary>
        ///
        public Product Retrieve(int productId)
        {
            //Create the instance of the product class
            //Pass in the requested id
            Product product = new Product(productId);

            // code that retrieves the defined product

            //temporary hard-coded values to returnb
            //a populated ProductRepository

            if (productId == 2)
            {
                product.ProductName = "Flores";
                product.ProductDescription = "Tulipa";
                product.CurrentPrice = 15.96M;
            }
            Object myobj = new Object();
            Console.WriteLine($"Obj: {myobj.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }


        ///<summary>
        ///save the current product
        ///</summary>
        ///<returns></returns>
        public bool Save(Product product)
        {
            //implement code

            return true;
        }

    }
}
