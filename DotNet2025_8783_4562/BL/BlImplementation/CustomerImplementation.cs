using System;
using System.Collections.Generic;
using System.Linq;
using BL.BlApi;

namespace BL.BlImplementation;

internal class CustomerImplementation : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Customer item)
    {
        try
        {
         
            DO.Customer dalCustomer = BO.Tools.ToDO(item);
            int id = _dal.Customer.Create(dalCustomer);
            return id;
        }
        catch (DO.ObjectExistExeption ex)
        {
            throw new BO.BlObjectExistException("Customer ID already exists", ex);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Customer.Delete(id);
        }
        catch (DO.ObjectNotFoundExeption ex)
        {
            throw new BO.BlObjectNotFoundException("Customer not found", ex);
        }
    }

    public bool IsExists(int id)
    {
        try
        {
            var dalCustomer = _dal.Customer.Read(id);
            return dalCustomer != null;
        }
        catch (DO.ObjectNotFoundExeption)
        {
            return false;
        }
        catch (Exception ex)
        {
            throw new BO.BlInvalidInputException("An error occurred while checking if customer exists", ex);
        }
    }

    public BO.Customer? Read(int id)
    {
        try
        {
            DO.Customer? dalCustomer = _dal.Customer.Read(id);
            return dalCustomer == null ? null : BO.Tools.ToBO(dalCustomer);
        }
        catch (DO.ObjectNotFoundExeption ex)
        {
            throw new BO.BlObjectNotFoundException("Customer not found", ex);
        }
    }

    public BO.Customer? Read(Func<BO.Customer, bool>? filter)
    {
        // שימוש במתודת הרחבה LINQ
        return ReadAll().FirstOrDefault(filter!);
    }

    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        // שימוש בתחביר שאילתה LINQ (דרישה: לפחות 2 מכל סוג)
        var customers = from dalCust in _dal.Customer.ReadAll()
                        let boCust = BO.Tools.ToBO(dalCust!)
                        select boCust;

        if (filter != null)
        {
            customers = customers.Where(filter);
        }

        return customers.ToList()!;
    }

    public void Update(BO.Customer item)
    {
        try
        {
            // בדיקת קלט בסיסית
            if (string.IsNullOrEmpty(item.CustomerName))
                throw new BO.BlInvalidInputException("Customer name cannot be empty");

            DO.Customer dalCustomer = BO.Tools.ToDO(item);
            _dal.Customer.Update(dalCustomer);
        }
        catch (DO.ObjectNotFoundExeption ex)
        {
            throw new BO.BlObjectNotFoundException("Customer not found for update", ex);
        }
    }
}