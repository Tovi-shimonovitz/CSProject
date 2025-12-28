

namespace DalApi;

public interface IDal//<T>
{
   // public ICrud<T> Crud { get;  }
    public ICustomer Customer { get;  }
    public ISale Sale { get;  }
    public IProduct Product { get; }
}
