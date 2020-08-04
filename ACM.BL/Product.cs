using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public string ProductName { get; set; }
        public int ProductId{ get; private set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; } 

        ///<summary>
        ///retrieve one product
        ///</summary>
        ///
        public Product Retrieve(int productId)
        {
            //implement code

            return new Product();
        }

        ///<summary>
        ///retrieve all products
        ///</summary>
        ///
        public List<Product> Retrieve()
        {
            //implement code

            return new List<Product>();
        }


        ///<summary>
        ///save product
        ///</summary>
        ///
        public bool Save()
        {
            //implement code

            return true;
        }


        ///<summary>
        ///validates the product data
        ///</summary>
        ///
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductDescription)) isValid = false;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }

    }
}
