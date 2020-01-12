using CodeFirstDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Orders.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public void Get(int id)
        {
            var address = new Address() { AddressId = 2, PostCode = "ST1 5HX", StreetName = "CenturyStreet" };
            var order = new Order() { OrderId = 2, ItemName = "Laptop" };
            var orders = new List<Order>();
            var deliveraddress = new DeliveryAddress() { DevliverAddressID = 2, DeliveryAddressPostCode = "MK80BA", NickName = "MK- Addresss" };
            address.DeliverAddress = deliveraddress;
            orders.Add(order);
            var customer = new Customer() { Name = "Danny", CustomerId = 2, CustomerAddress = address, orders = orders };
            using (var context = new BillingContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        // GET api/values/5
        public List<Customer> Get()
        {
            var result = new List<Customer>();
            using (var context = new BillingContext())
            {
                result = context.Customers.Include("CustomerAddress.DeliverAddress").Include("orders").ToList();
            }
            return result;
        }

            // POST api/values
            public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
