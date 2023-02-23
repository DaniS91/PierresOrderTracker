using System;
using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  { 
    public string Item { get; set; }
    private static List<Order> _instances = new List<Order> {};
    public Order(string item)
    {
      Item = item;
      _instances.Add(this);
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}