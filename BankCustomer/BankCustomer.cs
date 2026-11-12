using System;
namespace BankCustomer;


class BankCustomer
{

    public string FirstName = "Tim";
    public string LastName = "Shao";
    public string CustomerId = "1010101010";

    public BankCustomer()
    {
        Console.WriteLine("BankCustomer created");
    }
    public BankCustomer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

     public BankCustomer(string firstName, string lastName, string custommerId)
    {
        FirstName = firstName;
        LastName = lastName;
        CustomerId = custommerId;
    }
}