namespace Infrastructure
{
  using System.Collections.Generic;
  using Domain;

  public class ProductRepository : IProductRepository
  {
    private readonly Dictionary<int, Product> _products = new();

    public void Add(Product product)
    {
      _products.Add(product.Id, product);
    }

    public Product? GetById(int id) => _products.TryGetValue(id, out var product) ? product : null;
      

    public IEnumerable<Product> List()
    {
      return _products.Values;
    }
  }
  
  public class OrderRepository : IOrderRepository
  {
    private readonly Dictionary<int, Order> _orders = new();
    public void Add(Order order)
    {
      _orders.Add(order.Id, order);
    }

    public Order? GetById(int id) => _orders.TryGetValue(id, out var order) ? order : null;

    public IEnumerable<Order> List()
    {
      return _orders.Values;
    }

    public void Update(Order order)
    {
      _orders[order.Id] = order;
    }
  }
}