namespace BankCustomer;

class Program
{

    static void Main(string[] args)
    {
        string firstName = "Tim";
        string lastName = "Shao";
        string customerId = "1010101010";

        BankCustomer customer1 = new BankCustomer();

        firstName = "Lisa";
        BankCustomer customer2 = new BankCustomer(firstName, lastName);

        firstName = "Sandy";
        lastName = "Zoeng";
        customerId = "2020202020";
        BankCustomer customer3 = new BankCustomer(firstName, lastName, customerId);

        Console.WriteLine($"Customer 1: {customer1.FirstName} {customer1.LastName}, ID: {customer1.CustomerId}");
        Console.WriteLine($"Customer 2: {customer2.FirstName} {customer2.LastName}, ID: {customer2.CustomerId}");
        Console.WriteLine($"Customer 3: {customer3.FirstName} {customer3.LastName}, ID: {customer3.CustomerId}");
    }

}
