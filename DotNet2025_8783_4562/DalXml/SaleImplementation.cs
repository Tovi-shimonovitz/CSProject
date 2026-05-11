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
    internal class SaleImplementation : ISale
    {
       public static readonly string  PATH = @"../xml/sales.xml";
        //static List<Sale> Load()
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        //    using (StreamWriter sw = new StreamWriter(PATH))
        //    {
        //        return (List<Sale>)serializer.Deserialize(sw,list);
        //    }
        //}

        public void Save(List<Sale> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            using (StreamWriter sw = new StreamWriter(PATH))
            {
                serializer.Serialize(sw, list);
            }
        }
        public int Create(Sale item)
        {
            List<Sale> list = ReadAll();
            if (list.FirstOrDefault(s => s.SaleId == item.SaleId) != null)
                throw new ObjectExistExeption($"this  sale already exists exeption");
            list.Add(item);
            Save(list);
            return item.SaleId;

        }

        public void Delete(int id)
        {
            List<Sale> list = ReadAll();
            Sale item = list.FirstOrDefault(s=> s.SaleId == id);
            if (item == null) {
                 throw new ObjectNotFoundExeption($"this  sale not exists");
            }
            list.Remove(item);
            Save(list);
        }

        public Sale? Read(int id)
        {
            List<Sale> list = ReadAll();
            var item = list.FirstOrDefault(s=> s.SaleId == id);
            if (item == null)
                throw new ObjectNotFoundExeption($"this  sale not exists");
            return item;
           
        }

        public Sale? Read(Func<Sale, bool>? filter)
        {
            List<Sale> list = ReadAll();
            Sale item = list.FirstOrDefault(filter);
            if(item == null)
                throw new ObjectNotFoundExeption($"this  sale not exists");
            return item;
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            if (!File.Exists(PATH)) return new List<Sale>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            using (StreamReader sr = new StreamReader(PATH))
            {
                var products = (List<Sale>)serializer.Deserialize(sr);
                return products ?? new List<Sale>();
            }
        }

        public void Update(Sale item)
        {
            List<Sale> list = ReadAll();
            Sale sale = list.FirstOrDefault(s=> s.SaleId == item.SaleId);
            if(sale == null)
            {
                throw new ObjectNotFoundExeption($"this  sale not exists");
            }
            list.Remove(sale);
            list.Add(item);
            Save(list);

        }
    }
}
