namespace Exercise1;

public class Employee : Person
{
    public double Salary { get; set; }
    public List<Sale> SalesList { get; set; } = new();

    public Employee(
        string firstName, string lastName, int age, double salary
    ) : base(firstName, lastName, age)
    {
        Salary = salary;
    }

    public override string ToString() => $"Employee: {FirstName} {LastName}";

    private int GetNumberOfSales() => SalesList?.Count ?? 0;

    private double GetSalesTotal()
    {
        double total = 0;
        if (SalesList is not null)
            foreach (var item in SalesList)
                total += item.Price;
        return total;
    }

    private double GetAverageSale() => GetNumberOfSales() > 0 ? GetSalesTotal() / GetNumberOfSales() : 0;

    public void PrintSalesStatistic()
    {
        Console.WriteLine(
            $"\nFollowing is statistic for {FirstName} {LastName}!\n" +
            $"Number of sales: {GetNumberOfSales()}\n" +
            $"Sales total: ${GetSalesTotal()}\n" +
            $"Average sales: ${GetAverageSale()}\n"
        );
    }

    private static void PrintSaleItem(Sale item)
    {
        Console.WriteLine(
            $"Product: {item.Product, -10} Price: ${item.Price, -9} Buyer: {item.Client.GetFullName()}"
        );
    }

    public void PrintSalesList()
    {   
        Console.WriteLine("List of sales\n");
        foreach (var item in SalesList)
            PrintSaleItem(item);
        Console.WriteLine(new string('-', 50));
    }
}
