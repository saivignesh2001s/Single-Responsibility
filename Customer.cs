using Single_Responsibility;
using System;
using System.Net.Http.Headers;

public class customer
{
	public int Id { get; set; }
	public string Name { get; set; }

}
public interface ICustomer
{
	void AddCustomer(customer c);
	void UpdateCustomer(int id,customer c);
	void DeleteCustomer(int id);

    void printcustomers();
}
public class Customer : ICustomer
{
    public Customer()
    {
        customers.Capacity = 10;
    }
    List<customer> customers = new List<customer>();
    public void AddCustomer(customer c)
    {
        try
        {
            if (customers.Count < customers.Capacity)
            {
                customers.Add(c);
            }
            else
            {
                throw new Exception("Index out of bounds");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Into the error");
            Errorlog.Writelog(new string[]{ex.Message.ToString()});
        }
    }

    public void DeleteCustomer(int id)
    {
        try
        {
           customer k=null;
        foreach (customer c in customers)
            {
                if (c.Id == id) { 
                k = c;
                customers.Remove(c);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Into the error");
            Errorlog.Writelog(new string[] { ex.Message.ToString() });

        }
    }

    public void printcustomers()
    {
        try
        {
            foreach(var c in customers)
            {
                Console.Write(c.Id);
                Console.Write(' ');
                Console.WriteLine(c.Name);
            }
        }
    catch (Exception ex)
        {
            Console.WriteLine("Into the error");
            Errorlog.Writelog(new string[] { ex.Message.ToString() });
        }
    }

    public void UpdateCustomer(int id,customer c)
    {
        try
        {
            foreach(var customer in customers)
            {
                if(customer.Id == id)
                {
                    customer.Id = id;
                    customer.Name = c.Name;
                }
            }
        }
        catch (Exception ex) {
            Console.WriteLine("Into the error");

            Errorlog.Writelog(new string[] { ex.Message.ToString() });
        }
    }
}
