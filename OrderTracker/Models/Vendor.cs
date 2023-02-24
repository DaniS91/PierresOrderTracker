using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public Vendor(string name, string description, string location)
    {
      Name = name;
      Description = description;
      Location = location;
    }
  }
}