using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cui_Jall_Restraurent__Management;



namespace Unit_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodTotalCustomerBill()
        {
            CustomerBilling cusBill = new CustomerBilling();

            int testAmount = cusBill.CustomerBillCalculation(15,16,17);

            int Expected = 15 + 16 +17;

            Assert.AreEqual(Expected,testAmount);
        }

        [TestMethod]
        public void  TestMethodTotalStock()
        {
            MenuStock mstock = new MenuStock();
           int Totalstock= mstock.StockCalculation(10, 15, 20);

           int ExpectedStock = (10 + 15) - 20;

           Assert.AreEqual(ExpectedStock, Totalstock);

        }
        [TestMethod]
        public void TestMethodMenuPrice()
        {
            MenuPrice p = new MenuPrice();
            int totalmenuprice  = p.menuPrice(10,30,40);

            int expectedMenuprice = 10 + 30 + 40;
            Assert.AreEqual(expectedMenuprice,totalmenuprice);


        }

      


        
    }
}
