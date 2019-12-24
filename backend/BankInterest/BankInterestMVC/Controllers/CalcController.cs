using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankInterest;
using Microsoft.AspNetCore.Mvc;

namespace BankInterestMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        
        // GET api/calc
        [HttpGet]
        public ActionResult<decimal> Get(decimal amount = 1000.0M, int years = 10)
        {
            BankCalc bankCalc = new BankCalc();
            return bankCalc.CalculateAmountNoInterest(amount, years);
        }

        // GET api/calc/simpleinterest
        [HttpGet("simpleinterest")]
        public ActionResult<decimal> GetSimpleInterest(decimal amount = 1000.0M, decimal interest = 1.0M, int years = 10)
        {
            BankCalc bankCalc = new BankCalc();
            return bankCalc.CalcSimpleBankInterest(amount, interest, years);
        }

        // GET api/calc/compoundinterest
        [HttpGet("compoundinterest")]
        public ActionResult<double> GetCompoundInterest(double amount = 1000.0, double interest = 0.0, int years = 10)
        {
           
            BankCalc bankCalc = new BankCalc();
            return bankCalc.CalcCompoundBankInterest(amount, interest, years);
        }

    }
}
