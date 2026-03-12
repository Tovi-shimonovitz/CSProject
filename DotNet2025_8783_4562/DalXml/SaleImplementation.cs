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
        string PATH = "sales.xml";
        static List<Sale> Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            using (FileStream fs = new FileStream("sales.xml", FileMode.Open))
            {
                return (List<Sale>)serializer.Deserialize(fs);
            }
        }

        static void Save(List<Sale> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            using (FileStream fs = new FileStream("sales.xml", FileMode.Create))
            {
                serializer.Serialize(fs, list);
            }
        }
        public int Create(Sale item)
        {
            List<Sale> list = Load();
            list.Add(item);
            return item.SaleId;

        }

        public void Delete(int id)
        {
            List<Sale> list = Load();
            Sale item = list.FirstOrDefault(s=> s.SaleId == id);
            if (item != null) {
                 throw new ObjectNotFoundExeption($"this  sale not exists");
            }
            list.Remove(item);
            Save(list);
        }

        public Sale? Read(int id)
        {
            List<Sale> list = Load();
            var item = list.FirstOrDefault(s=> s.SaleId == id);
            if (item == null)
                throw new ObjectNotFoundExeption($"this  sale not exists");
            return item;
           
        }

        public Sale? Read(Func<Sale, bool>? filter)
        {
            List<Sale> list = Load();
            Sale item = list.FirstOrDefault(filter);
            if(item == null)
                throw new ObjectNotFoundExeption($"this  sale not exists");
            return item;
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            List<Sale> list = Load();
            List<Sale?> result = list.Where(filter).ToList();
            return result;
        }

        public void Update(Sale item)
        {
            List<Sale> list = Load();
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
