using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendors.Models;
using System;

namespace PierresVendors.Test
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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
    [TestMethod]
    public void GetAll_RetrunsAllOrdersCreated_Orders()
    {
      string orderTitle1 = "title";
      string orderDescription1 = "description";
      string orderPrice1 = "price";
      string orderDate1 = "date";
      Order newOrder1 = new Order(orderTitle1, orderDescription1, orderPrice1, orderDate1);
      string orderTitle2 = "title";
      string orderDescription2 = "description";
      string orderPrice2 = "price";
      string orderDate2 = "date";
      Order newOrder2 = new Order(orderTitle2, orderDescription2, orderPrice2, orderDate2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> testResult = Order.GetAll();
      CollectionAssert.AreEqual(newList, testResult);
    }
  }
 
}