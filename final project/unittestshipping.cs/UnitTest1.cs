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
        public void TestSuccesvolBetalen()
        {
            CreditCard creditcard = new CreditCard();
            bool resultaat = true;
            List<SaleLinesItem> productdb = new List<SaleLinesItem>();
            creditcard.Resultaat(resultaat, productdb);

            bool test = creditcard.geslaagd;
            Assert.IsTrue(test);
        }

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
        public void GeenProductenMetAantal0()
        {
            int expected = 1;
            int a = 0;
            string aantal = a.ToString();

            List<SaleLinesItem> testproductdb = new List<SaleLinesItem>();
            ProductInformatie product1 = new ProductInformatie("testitem1", "testbeschrijving1", 10.00f, "Fysiek", "");
            testproductdb.Add(new SaleLinesItem("1", product1));

            ProductInformatie product2 = new ProductInformatie("testitem2", "testbeschrijving2", 10.00f, "Fysiek", "");
            winkelmand w = new winkelmand();
            w.productdb = testproductdb;
            w.addtocart(aantal, product2);

            int actual = w.productdb.Count;

            Assert.AreEqual(expected, actual, 0.001, "Product is toegevoegd. test failed");
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
