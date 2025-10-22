namespace Domain
{
  #region Enum
  public enum OrderStatus
  {
    New,
    Paid,
    Shipped,
    Cancelled
  }
  #endregion

  #region Entità
  public class Product
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public Money Price { get; set; }

    public override string ToString()
    {
      return $"[{Id}] {Name} - {Price}";
    }
  }

  public class Customer
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }


    public override string ToString()
    {
      return $"[{Id}] {Name} - {Email}";
    }
  }
  public class OrderItem(Product product, int Quantity)
  {
    public Money unitPrice { get; set; }
    public Money Totale => new Money(unitPrice.Amount * Quantity);
  }

  public class Order
  {
    public int Id { get; set; }
    public Customer CustomerId { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.New;
    private readonly List<OrderItem> _items = new();
    public IReadOnlyList<OrderItem> Items => _items;

    public void AddItem(OrderItem item)
    {
      _items.Add(item);
    }

    public Money SubTotal()
    {
      decimal sum = _items.Sum(x => x.Totale.Amount);
      return new Money(sum);
    }

    public void Pay()
    {
      if (Status != OrderStatus.New) throw new InvalidOperationException("Ordine già pagato");
      Status = OrderStatus.Paid;
    }

    public void Ship()
    {
      if (Status != OrderStatus.Paid) throw new InvalidOperationException("Ordine non pagato");
      Status = OrderStatus.Shipped;
    }

    public void Cancel()
    {
      if (Status == OrderStatus.Cancelled) throw new InvalidOperationException("Ordine annullato");
      Status = OrderStatus.Cancelled;
    }
  }

  public class Money
  {
    public decimal Amount { get; }
    public string Currency { get; }

    public Money(decimal amount, string currency = "EUR")
    {
      Amount = decimal.Round(amount, 2);
      Currency = currency;
    }

    public override string ToString() => $"{Amount:0.00} {Currency}";
  }

  public interface IConfigurationProvider
  {
    decimal IvaPercent { get; }
    string Currency { get; }
  }
    
  public sealed class ConfigurationProvider : IConfigurationProvider
  {
    public decimal IvaPercent { get; }
    public string Currency { get; }

    private ConfigurationProvider(decimal ivaPercent, string currency)
    {
      IvaPercent = ivaPercent;
      Currency = currency;
    }

    private static readonly Lazy<ConfigurationProvider> _lazy = new(() => new ConfigurationProvider(0.22m, "EUR"));
    
    public static ConfigurationProvider istance => _lazy.Value;
  }
  #endregion

  #region Interfacce
  public interface IProductRepository
  {
    Product? GetById(int id);
    IEnumerable<Product> List();
    void Add(Product p);
  }

  public interface IOrderRepository
  {
    void Add(Order o);
    Order? GetById(int id);
    IEnumerable<Order> List();
    void Update(Order o);
  }

  public interface INotificationService
  {
    void Notify(string to, string subject, string body);
  }
  #endregion

}