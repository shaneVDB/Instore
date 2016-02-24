using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shane.InStore.WebApi.Models
{
    public class Receipt
    {
        public Guid Id { get; set; }
        public int BranchCode { get; set; }
        public string DocumentNumber { get; set; }
        public int TranType { get; set; }
        public int SubCode { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime FinPeriod { get; set; }
        public string OtherBranch { get; set; }
        public string SubAccount { get; set; }
        public string EmployeeId { get; set; }
        public Double ReceiptAmount { get; set; }
        public string ReceiptDetails { get; set; }
        public string EasyPayNumber { get; set; }

    }
}