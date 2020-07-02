using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingSystem
{
    public class LoanReleasingDataModel
    {
        public int loanId { get; set; }
        public int customerId { get; set; }
        public string loanNo { get; set; }
        public double amountReleased { get; set; }
        public double interestIncome { get; set; }
        public int paymentTerms { get; set; }
        public DateTime dateReleased { get; set; }
        public DateTime dueDate { get; set; }
        public string paymentMode { get; set; }
        public double dueAmount { get; set; }
        public string getUser { get; set; }
        public DateTime getLogs { get; set; }

        public double amountPaid { get; set; }
        public string particulars { get; set; }
    }

    public class PaymentSchedule
    {
        public int Id { get; set; }
        public string loanNo { get; set; }
        public int paymentSchedule { get; set; }
        public double amountSchedule { get; set; }
        public bool isPaid { get; set; }
        public DateTime datepaid { get; set; }
    }
}
