using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInterest
{
    public class BankCalc
    {

        public double CalcCompoundBankInterest(double amount = 1000, double interestRate = 0.0, int numYears = 10)
        {

            double total = 0;
            if (interestRate > 0)
            {                
                for (int i = 1; i <= numYears; i++)
                {
                    total += amount * Math.Pow(1 + ((interestRate / 100) / numYears), (12 * i));
                }
            } else
            {
                total = amount * numYears;
            }

            return total;
        }
        public decimal CalcSimpleBankInterest (decimal amount = 1000, decimal interestRate = 0.0M, int numYears = 10)
        {
            decimal total = 0.0M;
            if (interestRate > 0.0M)
            {
                for (int i = 1; i <= numYears; i++)
                {
                    total += amount + (amount * numYears * (interestRate / 100.0M));
                } 
            } else
            {
                total = amount * numYears;
            }
            
            return total;
        }
        public decimal CalculateAmountNoInterest (decimal startingAmount = 1000, int numYears = 10)
        {
            decimal total = 0.0M;
            total = startingAmount * numYears;
            return total;
        }
    }
}
