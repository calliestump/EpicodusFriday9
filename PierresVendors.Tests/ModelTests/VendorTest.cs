using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendor.Models;
using System;

namespace PierresVendor.Test
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose() 
    {
      Vendor.ClearAll();
    }
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
      Vendor newVendor = new Vendor (vendorName, vendorDescription);
      string vendorNameTest = newVendor.VendorName;
      string vendorDescriptionTest = newVendor.VendorDescription;
      Assert.AreEqual(vendorName, vendorNameTest);
      Assert.AreEqual(vendorDescription, vendorDescriptionTest);
    }
    [TestMethod]
    public void RetrunId_VendorId_Int()
    {
      string vendorName = "Haylee's Cafe";
      string vendorDescription = "Haylee's cafe is known for their delicous coffee, sandwhiches, baked goods and modern decor.";
      Vendor newVendor = new Vendor (vendorName, vendorDescription);
      int idResult = newVendor.Id;
      Assert.AreEqual(1, idResult);
    }
    [TestMethod]
    public void GetAll_ReturnsAllObjects_VendorList()
    {
      string vendorName1 = "Haylee's Cafe";
      string vendorDescription1 = "Haylee's cafe is known for their delicous coffee, sandwhiches, baked goods and modern decor.";
      Vendor newVendor1 = new Vendor (vendorName1, vendorDescription1);
      string vendorName2 = "Mabelys's Cafe";
      string vendorDescription2 = "Mabelys's cafe is known for their delicous smoothies, fruits, organic baked goods and graphic illustration.";
      Vendor newVendor2 = new Vendor (vendorName2, vendorDescription2);
      List<Vendor> newVendor = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> testResult = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendor, testResult);
    }

    [TestMethod]
    public void Find_RetrunsCorrectVendorById_Vendor()
    {
      string vendorName1 = "Haylee's Cafe";
      string vendorDescription1 = "Haylee's cafe is known for their delicous coffee, sandwhiches, baked goods and modern decor.";
      Vendor newVendor1 = new Vendor (vendorName1, vendorDescription1);
      string vendorName2 = "Mabelys's Cafe";
      string vendorDescription2 = "Mabelys's cafe is known for their delicous smoothies, fruits, organic baked goods and graphic illustration.";
      Vendor newVendor2 = new Vendor (vendorName2, vendorDescription2);
      Vendor testResult = Vendor.Find(1);
      Assert.AreEqual(newVendor1, testResult);
    }
    [TestMethod]
    public void AddOrderToVendor_PassesOrderObjectIntoVendorObject_Order()
    {
      string orderTitle = "title";
      string orderDescription = "description";
      string orderPrice = "price";
      string orderDate = "date";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "Haylee's Cafe";
      string vendorDescription = "Haylee's cafe is known for their delicous coffee, sandwhiches, baked goods and modern decor.";
      Vendor newVendor = new Vendor (vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);
    }
  }
}