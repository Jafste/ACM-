using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        //propg
        //ctor
       public Address Retrieve(int addressId)
        {
            //Create the instance of the Address class
            //Pass in the resqueted ID
            Address address = new Address(addressId);

            //code that retrieves the defined address

            //Temporaryu hard coded values to return
            //a poplated adress (teste)

            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "bag";
                address.StreetLine2 = "row";
                address.City = "hob";
                address.State = "aveiro";
                address.Country = "Portugal";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId (int customerId)
        {
            //code that retrieves the defined address
            //for customer

            //temporary hard-coded values
            //set an address for a customer

            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "bag",
                StreetLine2 = "row",
                City = "hob",
                State = "aveiro",
                Country = "Portugal",
                PostalCode = "144",
            };
            
             addressList.Add(address);

             address = new Address(2)
            {
                AddressType = 1,
                StreetLine1 = "2",
                StreetLine2 = "2",
                City = "2",
                State = "2",
                Country = "Portugal",
                PostalCode = "145",
            };

            addressList.Add(address);

            return addressList;
        }

        ///<summary>
        ///save the current address
        ///</summary>
        ///<returns></returns>
        public bool Save(Address address)
        {
            //implement code

            return true;
        }
    }
}
