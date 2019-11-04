using Microsoft.VisualStudio.TestTools.UnitTesting;
using final_project;
using System.Collections.Generic;
using System.Diagnostics;

namespace unittestshipping.cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestShippingCostgeen()
        {
            float expected = 10.00f;

            List<SaleLinesItem> productdb = new List<SaleLinesItem>();
            ProductInformatie product1 = new ProductInformatie("testitem1", "testbeschrijving1", 10.00f, "Digitaal", "");
            productdb.Add(new SaleLinesItem("1", product1));

            sales sale = new sales();
            float actual = sale.TotalPricecalc(productdb);

            Assert.AreEqual(expected, actual, 0.001, "Verzendkosten zijn erbij toegevoegd. test failed");
        }

        [TestMethod]
        public void TestShippingCostmet()
        {
            float expected = 12.50f;

            List<SaleLinesItem> productdb = new List<SaleLinesItem>();
            ProductInformatie product1 = new ProductInformatie("testitem1", "testbeschrijving1", 10.00f, "Fysiek", "");
            productdb.Add(new SaleLinesItem("1", product1));

            sales sale = new sales();
            float actual = sale.TotalPricecalc(productdb);

            Assert.AreEqual(expected, actual, 0.001, "Verzendkosten zijn er niet bij toegevoegd. test failed");
        }
    }
}
