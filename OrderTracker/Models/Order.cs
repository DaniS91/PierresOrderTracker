using System;
using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  { 
    public string Item { get; set; }

    public Order(string item)
    {
      Item = item;
    }
  }
}