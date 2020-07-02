using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingSystem 
{
    public class LoanDetailsDataModel
    {
        public int customerId { get; set; }
        public string loanNo { get; set; }
        public double dueAmount { get; set; }
        public double principalLoan { get; set; }
        public double interestIncome { get; set; }
    }
}
