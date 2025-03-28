namespace Exercise1;

public class Customer : Person
{
    public List<Sale> PurchasesList { get; set; } = new();

    public Customer(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {

    }

    public override string ToString()
    {
        return $"Customer: {FirstName} {LastName}";
    }
}
