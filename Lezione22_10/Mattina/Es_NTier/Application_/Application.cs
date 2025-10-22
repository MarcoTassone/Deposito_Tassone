using System.Security.Cryptography.X509Certificates;
using Domain;

namespace Application
{
  using Domain;
  public class ProductService
  {
    private readonly IProductRepository _repositoryProduct;
    private readonly ConfigurationProvider _configurationProvider;
    public ProductService(IProductRepository repository, ConfigurationProvider cfg)
    {
      _repositoryProduct = repository;
      _configurationProvider = cfg;
    }

    public void CreaProduct(int id, string productName, decimal price)
    {
      var p = new Product(id, productName, new Money(price, _configurationProvider.Currency));
      _repositoryProduct.Add(p);
    }

    public Product Require(int id) => _repositoryProduct.GetById(id);

    public IEnumerable<Product> ElencaProdotti() => _repositoryProduct.List();
  }

  public class OrderService
  {
    private readonly IOrderRepository _repositoryOrder;
    private readonly ConfigurationProvider _configurationProvider;
    private readonly ProductService _productService;

    public OrderService(IOrderRepository repository, ConfigurationProvider cfg, ProductService productService)
    {
      _repositoryOrder = repository;
      _configurationProvider = cfg;
      _productService = productService;
    }

    public void CreaOrder(string customer)
    {
      var order = new Order(new Customer(customer));
      _repositoryOrder.Add(order);
    }

    public void AddOrder(int orederId, int productId, int quantity)
    {
      var o = _repositoryOrder.GetById(orederId);
      var p = _productService.Require(productId);
      var item = new OrderItem(p, quantity);

      o.AddItem(item);
    }

    public Money CalcolaTotal(int orderId)
    {
      var order = _repositoryOrder.GetById(orderId);
      var subtotal = order.SubTotal();
      return new Money(subtotal.Amount * _configurationProvider.IvaPercent, _configurationProvider.Currency);
    }

    public void Ship(int orderId)
    {
      var order = _repositoryOrder.GetById(orderId);
      order.Ship();
      _repositoryOrder.Update(order);
    }

    public void Cancel(int orderId)
    {
      var order = _repositoryOrder.GetById(orderId);
      order.Cancel();
      _repositoryOrder.Update(order);
    }

    public Order Require(int id) => _repositoryOrder.GetById(id);

    public void Update(Order order) => _repositoryOrder.Update(order);

    public IEnumerable<Order> ElencaOrdini() => _repositoryOrder.List();
  }
}