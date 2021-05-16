using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      _instances.Add(this);
      Description = description;
      Price = price;
      Date = date; 
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
     public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}