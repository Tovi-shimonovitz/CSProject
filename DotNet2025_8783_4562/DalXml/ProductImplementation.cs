using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        string PATH = "products.xml";

        public void save(List<Product> products)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (StreamWriter sw = new StreamWriter(PATH))
            {
                serializer.Serialize(sw, products);
            }
        }
        public List<Product> GetAllProducts()
        {
            if (!File.Exists(PATH)) return new List<Product>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (StreamReader sr = new StreamReader(PATH))
            {
                var products = (List<Product>)serializer.Deserialize(sr);
                return products ?? new List<Product>();
            }
        }
      

        public int Create(Product item)
        {
            List<Product> products = GetAllProducts();
            products.Add(item);
            save(products);
            return item.ProductId;
        }

        public void Delete(int id)
        {
            List<Product> products = GetAllProducts();

            if (products.FirstOrDefault(p => p.ProductId == id) == null)
                throw new ObjectNotFoundExeption("notContainThisIdException");
           
            Product productRemove = products.FirstOrDefault(p => p.ProductId == id);
           
            products.Remove(productRemove);
            save(products);

        }
        public Product? Read(int id)
        {
            List<Product> products= GetAllProducts();
            if (products.FirstOrDefault(p => p.ProductId == id) == null)
                throw new ObjectNotFoundExeption("notContainThisIdException");
            return products.FirstOrDefault(p => p.ProductId==id);
        }

        public Product? Read(Func<Product, bool>? filter)
        {
            if(filter == null)
                return null;
            List<Product> products = GetAllProducts();
            Product? product = products.FirstOrDefault(filter);
           
            if (product == null)
                throw new ObjectNotFoundExeption("notContainThisIdException");
            return product;
        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            List<Product> products = GetAllProducts();
            if (products == null)
                return null;
            if (filter == null)
                return products.Select(p => (Product?)p).ToList();
            return products.Where(filter).Select(p => (Product?)p).ToList();
        }

        public void Update(Product item)
        {
            List<Product> products=GetAllProducts();
          
            if(products.FirstOrDefault(p => p.ProductId == item.ProductId)==null)
                throw new ObjectNotFoundExeption("notContainThisIdException");
          
            products.Remove(products.FirstOrDefault(p => p.ProductId == item.ProductId));
            products.Add(item);
            save(products);

        }
    }
}
