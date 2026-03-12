using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        private XElement root = XElement.Load("customers");
        private string CUSTOMER = "customer";
        private string ID = "CustomerId";
        private string NAME = "CustomerName";
        private string ADDRESS = "Adress";
        private string PHONE = "Phone";
        public int Create(Customer item)
        {
            
            if (root.Descendants("Customer").Any(c => (int)c.Element("CustomerId") == item.CustomerId))
            {
                throw new ObjectExistExeption("this customer already exists exeption");
            }

            root.Add(new XElement("Customer",
                               new XElement("CustomerId", item.CustomerId),
                               new XElement("CustomerName", item.CustomerName),
                               new XElement("Address", item.Adress),
                               new XElement("Phone", item.Phone)));


            root.Save("customers");

            return item.CustomerId;
        }

        public void Delete(int id)
        {
           
            if (root.Descendants("Customer").Any(c => (int)c.Element("CustomerId") == id))
            {
                throw new ObjectNotFoundExeption("notContainThisIdException");

            }
            root.Descendants("Customer").FirstOrDefault(c => (int)c.Element("CustomerId") == id).Remove();
            root.Save("customers");

        }

        public Customer? Read(int id)
        {
     
            if (root.Descendants(ID).FirstOrDefault(i => int.Parse(i.Value) == id) == null)
                throw new ObjectNotFoundExeption("notContainThisIdException");
            var customerElement = root.Descendants(CUSTOMER)
                    .FirstOrDefault(c => (int?)c.Element("ID") == id);
            return new Customer
            {
                CustomerName = (string)customerElement.Element(NAME),
                CustomerId = (int)customerElement.Element(ID),
                Adress = (string)customerElement.Element(ADDRESS),
                Phone = (string)customerElement.Element(PHONE)
            };

        }

        public Customer? Read(Func<Customer, bool>? filter)
        {
           Customer customer= root.Elements(CUSTOMER).Select(c=> new Customer
           {
               CustomerName = (string)c.Element(NAME),
               CustomerId = (int)c.Element(ID),
               Adress = (string)c.Element(ADDRESS),
               Phone = (string)c.Element(PHONE)
           }).ToList().FirstOrDefault(filter);
            return customer;
   
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            List<Customer> customers = root.Elements(CUSTOMER).Select(c => new Customer
            {
                CustomerName = (string)c.Element(NAME),
                CustomerId = (int)c.Element(ID),
                Adress = (string)c.Element(ADDRESS),
                Phone = (string)c.Element(PHONE)
            }).ToList();
            return customers;
        }

        public void Update(Customer item)
        {
            Delete(item.CustomerId);
          root.Add(new XElement(CUSTOMER, new XElement("CustomerId", item.CustomerId),
                               new XElement("CustomerName", item.CustomerName),
                               new XElement("Address", item.Adress),
                               new XElement("Phone", item.Phone)));
            root.Save("customers");

        }
    }
}
