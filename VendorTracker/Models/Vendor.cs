using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public string Description { get; set; }
  

    public Vendor(string name, string description)
    {
      Name = name;
      _instances.Add(this);
      Description = description; 
      Id = _instances.Count; 
    }
      public static List<Vendor> GetAll()
      {

      }
      public static Vendor Find(int searchId)
      {
        return _instances[searchId - 1];
      }

      public static void ClearAll()
    {
      _instances.Clear();
    }
    }
  }