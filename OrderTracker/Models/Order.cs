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
    public Order(string title, string description, string date, string price)
    {
      Title = title;
      Description = description;
      Date = date;
      Price = price;
    }
  }
}