using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendors.Models;
using System;

namespace PierresVendors.Test
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void Vendor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("testArgument2");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
 
}