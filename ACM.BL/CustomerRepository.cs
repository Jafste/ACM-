using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        ///<summary>
        ///retrieve one costumer
        ///</summary>
        ///
        public Customer  Retrieve(int customerId)
        {
            //Create the instance of the Customer class
            //Pass in the requested id
            Customer customer = new Customer(customerId);

            // code that retrieves the defined custome
            
            //temporary hard-coded values to returnb
            //a populated customer

            if (customerId == 1)
            {
                customer.EmailAdress = "fb@gmail.com";
                customer.FirstName = "Marcos";
                customer.LastName = "Monteiro";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

      
        ///<summary>
        ///save the current costumer
        ///</summary>
        ///<returns></returns>
        public bool Save(Customer customer)
        {
            //implement code

            return true;
        }

    }
}
