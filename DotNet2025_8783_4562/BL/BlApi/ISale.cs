using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.BO;

namespace BL.BlApi;

public interface ISale
{
    public int Create(Sale item);
    public Sale? Read(int id);
    public Sale? Read(Func<Sale, bool>? filter);
    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null);
    public void Update(Sale item);
    public void Delete(int id);
}
