using System;
using System.Collections.Generic;
using System.Linq;
using BL.BlApi;

namespace BL.BlImplementation;

internal class SaleImplementation : ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Sale item)
    {
        try
        {
            _dal.Product.Read(item.ProductId);

            DO.Sale dalSale = BO.Tools.ToDO(item);
            return _dal.Sale.Create(dalSale);
        }
        catch (DO.ObjectNotFoundExeption ex)
        {
            throw new BO.BlObjectNotFoundException("Cannot create sale: Product not found", ex);
        }
        catch (DO.ObjectExistExeption ex)
        {
            throw new BO.BlObjectExistException("Sale already exists", ex);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Sale.Delete(id);
        }
        catch (DO.ObjectNotFoundExeption ex)
        {
            throw new BO.BlObjectNotFoundException("Sale not found", ex);
        }
    }

    public BO.Sale? Read(int id)
    {
        try
        {
            DO.Sale? dalSale = _dal.Sale.Read(id);
            return dalSale == null ? null : BO.Tools.ToBO(dalSale);
        }
        catch (DO.ObjectNotFoundExeption ex)
        {
            throw new BO.BlObjectNotFoundException("Sale not found", ex);
        }
    }

    public BO.Sale? Read(Func<BO.Sale, bool>? filter)
    {
        return ReadAll().FirstOrDefault(filter!);
    }

    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        var sales = _dal.Sale.ReadAll()
            .Select(s => BO.Tools.ToBO(s!));

        if (filter != null)
        {
            sales = sales.Where(filter);
        }

        return sales.ToList()!;
    }

    public void Update(BO.Sale item)
    {
        try
        {
            if (item.SaleStart > item.SaleEnd)
                throw new BO.BlInvalidInputException("Sale start date must be before end date");

            DO.Sale dalSale = BO.Tools.ToDO(item);
            _dal.Sale.Update(dalSale);
        }
        catch (DO.ObjectNotFoundExeption ex)
        {
            throw new BO.BlObjectNotFoundException("Sale not found for update", ex);
        }
    }
}