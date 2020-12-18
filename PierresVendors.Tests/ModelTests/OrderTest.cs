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
  }
 
}