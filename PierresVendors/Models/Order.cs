using System.Collections.Generic;

namespace PierresVendor.Models
{
  public class Order
  {
   public string Title { get; set; }
   public string OrderDescription { get; set ; }
   public string Price { get; set ; }
   public string Date { get; set ; }
   public int Id { get; }
   private static List<Order> _instances = new List<Order> {};

   public Order(string title, string orderDescription, string price, string date)
   {
     Title = title;
     OrderDescription = orderDescription;
     Price = price;
     Date = date;
     _instances.Add(this);
     Id = _instances.Count;
   }
   public static void ClearAll()
   {
     _instances.Clear();
   }
   public static List<Order> GetAll(){
     return _instances;
   }
   public static Order Find(int searchId)
   {
     return _instances[searchId - 1];
   }
  }
}