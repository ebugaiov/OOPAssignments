using System.Text;

namespace Exercise1;

public class Customer(string firstName, string lastName, int age) : Person(firstName, lastName, age)
{
    public List<Sale> PurchasesList { get; set; } = new();

    public override string ToString()
    {
        return $"Customer: {FirstName} {LastName}";
    }
    
    private int GetNumberOfPurchases() => PurchasesList.Count;

    private double GetPurchasesTotal()
    {
        double total = 0;
        
        foreach (var item in PurchasesList)
            total += item.Price;
        
        return total;
    }

    private double GetPurchasesAverage()
    {
        return GetNumberOfPurchases() > 0 ? GetPurchasesTotal() / GetNumberOfPurchases() : 0;
    }

    public void PrintPurchasesStatistic()
    {
        StringBuilder sb = new();
        sb.AppendLine($"Purchases statistic for {FirstName} {LastName}");
        sb.AppendLine($"Number of purchases: {GetNumberOfPurchases()}");
        sb.AppendLine($"Purchases Total: {GetPurchasesTotal()}");
        sb.AppendLine($"Average Purchases: {GetPurchasesAverage()}");
        
        Console.WriteLine(sb);
    }

    private void PrintPurchaseItem(Sale sale)
    {
        Console.WriteLine(
            $"Product: {sale.Product,-10} Price: ${sale.Price,-9} Seller: {sale.Seller.GetFullName()}"
        );
    }

    public void PrintPurchasesList()
    {
        Console.WriteLine("List of purchases\n");
        foreach (var item in PurchasesList)
            PrintPurchaseItem(item);
        Console.WriteLine(new string('-', 50));
    }
}
