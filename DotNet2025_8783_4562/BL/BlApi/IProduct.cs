using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.BO;

namespace BL.BlApi;

public interface IProduct
{
    public int Create(Product item);
    public Product? Read(int id);
    public Product? Read(Func<Product, bool>? filter);
    public List<Product?> ReadAll(Func<Product, bool>? filter = null);
    public void Update(Product item);
    public void Delete(int id);
    public void Sales(ProductInOrder productInOrder, bool IsPreferred);
}
