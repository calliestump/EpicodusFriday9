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
      Vendor newVendor = new Vendor("testArgument1", "testArgument2");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendorsNameAndDescription_ReturnsVendorsNameAndDescription_String()
    {
      string vendorName = "Haylee's Cafe";
      string vendorDescription = "Haylee's cafe is known for their delicous coffee, sandwhiches, baked goods and modern decor.";
      Vendor newVendor = new Vendor ();
      string vendorNameTest = newVendor.Name;
      string vendorDescriptionTest = newVendor.Description;
      Assert.AreEqual(vendorName, vendorNameTest);
      Assert.AreEqual(vendorDescription, vendorDescriptionTest);
    }
  }
}