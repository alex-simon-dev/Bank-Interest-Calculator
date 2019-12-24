using BankInterest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankInterestTest
{
    [TestClass]
    public class BankCalcTest
    {
        [TestMethod]
        public void CalculateBankInterestTest()
        {
            BankCalc bankCalc = new BankCalc();
            decimal actualValue = bankCalc.CalcSimpleBankInterestYears();
            Assert.AreEqual(10000.0M, actualValue);
        }
    }
}
