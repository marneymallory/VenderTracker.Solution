using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public int Id { get; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }
     public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}