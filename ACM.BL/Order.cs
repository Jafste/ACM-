using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        /// <summary>
        /// retrieve one Order
        /// </summary>
        ///
        public Order Retrieve(int OrderId)
        {
            //implement code

            return new Order();
        }

        /// <summary>
        /// retrieve all Order
        /// </summary>
        ///
        public List<Order> Retrieve()
        {
            //implement code

            return new List<Order>();
        }


        ///<summary>
        ///save Order
        ///</summary>
        ///
        public bool Save()
        {
            //implement code

            return true;
        }


        ///<summary>
        ///validates the Order data
        ///</summary>
        ///
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
