using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamQ1
{
    public enum PaymentPeriod
    {
        Annual = 1,
        BiAnnual,
        Quarterly,
        Monthly
    }

    public class Accounts
    {
        public int AccountID { get; set; }
        public string EirCode { get; set; }
        public PaymentPeriod PaymentPeriod { get; set; }
        public int ArrearsCount { get; set; }
    }
}
