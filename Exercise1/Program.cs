namespace Exercise1;

class Program
{
    public static void PrintPerson(Person person)
    {
        Console.WriteLine(person);
    }

    static void Main(string[] args)
    {
        // Person john = new("John", "Smith", 40);
        // Console.WriteLine(john);

        // Person susan = new("Susan", "Baba", 35);
        // Person dave = new("Dave", "Johnson", 30);

        // Console.WriteLine($"Count of Person's instances is {Person.GetInstanceCount()}");

        Employee employee1 = new("Ben", "Glob", 30, 20000);
        Employee employee2 = new("John", "Smith", 35, 25000);

        Customer customer1 = new("SecondBen", "SecondGlob", 35);
        Customer customer2 = new("Susan", "Baba", 40);

        // PrintPerson(employee1);
        // PrintPerson(customer1);

        Sale bentley = new("Bentley", 500_000, employee1, customer1);
        Sale maserati = new("Maserati", 600_000, employee1, customer2);

        employee1.PrintSalesStatistic();
        employee1.PrintSalesList();
        
        // Customers Statistic and Purchases List 
        customer1.PrintPurchasesStatistic();
        customer1.PrintPurchasesList();
    }
}
