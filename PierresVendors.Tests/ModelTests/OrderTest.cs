using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendors.Models;
using System;

namespace PierresVendors.Test
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesOrderInstance_Return()
    {
      Order newOrder = new Order("this", "is", "a", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetArguments_ReturnsArguments_String()
    {
      string orderTitle = "title";
      string orderDescription = "description";
      string orderPrice = "price";
      string orderDate = "date";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      string orderTitleTest = newOrder.Title;
      string orderDescriptionTest = newOrder.OrderDescription;
      string orderPriceTest = newOrder.Price;
      string orderDateTest = newOrder.Date;
      Assert.AreEqual(orderTitle, orderTitleTest);
      Assert.AreEqual(orderDescription, orderDescriptionTest);
      Assert.AreEqual(orderPrice, orderPriceTest);
      Assert.AreEqual(orderDate, orderDateTest);
    }
    [TestMethod]
    public void ReturnId_OrderId_Int()
    {
      string orderTitle = "title";
      string orderDescription = "description";
      string orderPrice = "price";
      string orderDate = "date";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      int idResult = newOrder.Id;
      Assert.AreEqual(1, idResult);
    }
  }
 
}