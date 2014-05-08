using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProjectCalculator
{
    [TestClass]
    public class UnitTest1
    {
        MainWindow main = new MainWindow();
        [TestMethod]
        public void TestMethodPenjumlahan()
        {
            double result = main.TestPenjumlahan(3, 1);
            double expected = 4;

            Assert.AreEqual(result, expected, "Penjumlahan salah");
        }
        [TestMethod]
        public void TestMethodPengurangan()
        {
            double result = main.TestPengurangan(3, 1);
            double expected = 2;

            Assert.AreEqual(result, expected, "Pengurangan salah");
        }
        [TestMethod]
        public void TestMethodPembagian()
        {
            double result = main.TestPembagian(4, 2);
            double expected = 2;

            Assert.AreEqual(result, expected, "Pembagian salah");
        }
        [TestMethod]
        public void TestMethodPerkalian()
        {
            double result = main.TestPerkalian(4, 2);
            double expected = 8;

            Assert.AreEqual(result, expected, "Perkalian salah");
        }
    }
}
