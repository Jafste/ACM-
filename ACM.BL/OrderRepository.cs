using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        ///<summary>
        ///Retrieve one order
        /// </summary>
        /// 
        public Order Retrieve (int orderId)
        {
            Order order = new Order(orderId);

            // code that retrieves the defined order

            //Temporary hard-coded Values

            if(orderId == 10)
            {
                //user cuirrent year in hard code
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }
        ///<summary>
        ///Saves the current ORder
        /// </summary>
        /// 
        public bool Save(Order order)
        {
            //code that saves the passed in order
            return true;
        }
    }
}
