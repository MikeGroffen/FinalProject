using Microsoft.VisualStudio.TestTools.UnitTesting;
using final_project;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTesting.cs
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestSuccesvolBetalen()
        {
            Betaling creditcard = new CreditCard();
            bool resultaat = true;
            List<SaleLinesItem> productdb = new List<SaleLinesItem>();
            bool test = creditcard.Betaalmethode(10.0f, productdb, resultaat);
            Assert.AreEqual(resultaat, test, "betaling is niet geslaagd terwijl dat wel zo is.");
        }

        [TestMethod]
        public void TestOnsuccesvolBetalen()
        {
            Betaling creditcard = new CreditCard();
            bool resultaat = false;
            List<SaleLinesItem> productdb = new List<SaleLinesItem>();
            bool test = creditcard.Betaalmethode(10.0f, productdb, resultaat);
            Assert.AreEqual(resultaat, test, "betaling is geslaagd terwijl dat niet zo is.");
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

        [TestMethod]
        public void TestShippingEenmalig()
        {
            float expected = 22.50f;

            List<SaleLinesItem> productdb = new List<SaleLinesItem>();
            ProductInformatie product1 = new ProductInformatie("testitem1", "testbeschrijving1", 10.00f, "Fysiek", "");
            productdb.Add(new SaleLinesItem("1", product1));
            ProductInformatie product2 = new ProductInformatie("testitem2", "testbeschrijving2", 10.00f, "Fysiek", "");
            productdb.Add(new SaleLinesItem("1", product1));

            sales sale = new sales();
            float actual = sale.TotalPricecalc(productdb);

            Assert.AreEqual(expected, actual, 0.001, "Verzendkosten zijn dubbel toegevoegd. test failed");
        }

        [TestMethod]
        public void TestAantalPrijsVerhouding()
        {
            float expected = 30.0f;

            List<SaleLinesItem> productdb = new List<SaleLinesItem>();
            ProductInformatie product1 = new ProductInformatie("testitem1", "testbeschrijving1", 10.00f, "Digitaal", "");
            productdb.Add(new SaleLinesItem("3", product1));

            sales sale = new sales();
            float actual = sale.TotalPricecalc(productdb);

            Assert.AreEqual(expected, actual, 0.001, "De prijs is niet keer het aantal producten gedaan. test failed");
        }

        [TestMethod]
        public void TestAantalGelijkeProducten()
        {
            int expected = 5;
            int a = 2;
            string aantal = a.ToString();
            int b = 3;
            string aantal2 = b.ToString();

            List<SaleLinesItem> testproductdb = new List<SaleLinesItem>();
            ProductInformatie product1 = new ProductInformatie("testitem1", "testbeschrijving1", 10.00f, "Fysiek", "");

            winkelmand w = new winkelmand();
            w.productdb = testproductdb;
            w.addtocart(aantal, product1);
            w.addtocart(aantal2, product1);

            int actual = int.Parse(testproductdb.Find(x => x.productnaam.Contains(product1.titel)).aantal);

            Assert.AreEqual(expected, actual, 0.001, "Aantal producten is onjuist. test failed");
        }

        [TestMethod]
        public void TestAantalVerschillendeFysiekeProducten()
        {
            int expected = 2;
            Verzend v = new Verzend();
            int i = 0;
            List<SaleLinesItem> testproductdb = new List<SaleLinesItem>();
            ProductInformatie product1 = new ProductInformatie("testitem1", "testbeschrijving1", 10.00f, "Fysiek", "");
            testproductdb.Add(new SaleLinesItem("4", product1));
            ProductInformatie product2 = new ProductInformatie("testitem2", "testbeschrijving2", 10.00f, "Fysiek", "");
            testproductdb.Add(new SaleLinesItem("3", product2));
            ProductInformatie product3 = new ProductInformatie("testitem3", "testbeschrijving3", 10.00f, "Digitaal", "");
            testproductdb.Add(new SaleLinesItem("2", product3));
            v.verzending(i, testproductdb);

            int actual = v.fysiekeproducten;
            Assert.AreEqual(expected, actual, 0.001, "Aantal producten is onjuist. test failed");
        }

        [TestMethod]
        public void TestAantalVerschillendeDigitaleProducten()
        {
            int expected = 2;
            Verzend v = new Verzend();
            int i = 0;
            List<SaleLinesItem> testproductdb = new List<SaleLinesItem>();
            ProductInformatie product1 = new ProductInformatie("testitem1", "testbeschrijving1", 10.00f, "Digitaal", "");
            testproductdb.Add(new SaleLinesItem("3", product1));
            ProductInformatie product2 = new ProductInformatie("testitem2", "testbeschrijving2", 10.00f, "Fysiek", "");
            testproductdb.Add(new SaleLinesItem("6", product2));
            ProductInformatie product3 = new ProductInformatie("testitem3", "testbeschrijving3", 10.00f, "Digitaal", "");
            testproductdb.Add(new SaleLinesItem("2", product3));
            v.verzending(i, testproductdb);

            int actual = v.digitaleproducten;
            Assert.AreEqual(expected, actual, 0.001, "Aantal producten is onjuist. test failed");
        }
    }
}
