using System;
using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  { 
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public string Price { get; set; }
    private static List<Order> _instances = new List<Order> {};
    public Order(string title, string description, string date, string price)
    {
      Title = title;
      Description = description;
      Date = date;
      Price = price;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}