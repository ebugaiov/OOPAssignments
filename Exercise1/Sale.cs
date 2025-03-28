namespace Exercise1;

public class Sale
{
    public string Product { get; set; }
    public double Price { get; set; }
    public Employee Seller { get; set; }
    public Customer Client { get; set; }
    public DateTime TransactionDate { get; set; }

    public Sale(string product, double price, Employee seller, Customer client)
    {
        Product = product;
        Price = price;
        Seller = seller;
        Client = client;
        TransactionDate = DateTime.Now;
        
        AddSaleToLists();
    }

    public void AddSaleToLists()
    {
        Seller.SalesList.Add(this);
        Client.PurchasesList.Add(this);
    }
}
