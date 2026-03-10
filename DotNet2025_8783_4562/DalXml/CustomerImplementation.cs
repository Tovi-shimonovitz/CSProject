using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        string CUSTOMER = "customer";
        private string ID = "CustomerId";
        private string NAME = "CustomerName";
        private string ADDRESS = "Adress";
        private string PHONE = "Phone";
        public int Create(Customer item)
        {
            XElement root = XElement.Load("customers");
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
            XElement root = XElement.Load("customers");

            if (root.Descendants("Customer").Any(c => (int)c.Element("CustomerId") == id))
            {
                throw new ObjectNotFoundExeption("notContainThisIdException");

            }
            root.Descendants("Customer").FirstOrDefault(c => (int)c.Element("CustomerId") == id).Remove();

        }

        public Customer? Read(int id)
        {
            XElement root = XElement.Load("customers");
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
            throw new NotImplementedException();
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
