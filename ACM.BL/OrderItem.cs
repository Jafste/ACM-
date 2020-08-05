using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        
        ///<summary>
        ///retrieve one costumer
        ///</summary>
        ///
        public OrderItem Retrieve(int orderItemId)
        {
            //implement code

            return new OrderItem();
        }

        ///<summary>
        ///retrieve all costumers
        ///</summary>
        ///
        public List<OrderItem> Retrieve()
        {
            //implement code

            return new List<OrderItem>();
        }


        ///<summary>
        ///save costumers
        ///</summary>
        ///
        public bool Save()
        {
            //implement code

            return true;
        }


        ///<summary>
        ///validates the customer data
        ///</summary>
        ///
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice  == null) isValid = false;
            return isValid;
        }
    }
}
