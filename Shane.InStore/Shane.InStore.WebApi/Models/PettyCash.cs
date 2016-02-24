using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shane.InStore.WebApi.Models
{
    public class PettyCash
    {
        public Guid Id { get; set; }
        public int BranchNumber { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime FinPeriod { get; set; }
        public int SubCode { get; set; }
        public string EmployeeNumber { get; set; }
        public string DrawEmployee { get; set; }
        public Double DrawAmount { get; set; }
        public string ReverseEmployee { get; set; }
        public string CreditDocumentNumber { get; set; }
        public DateTime CreditDocumentDate { get; set; }
        public string CreditEmployee { get; set; }
        public Double CreditAmount { get; set; }
        public int PettyCashType { get; set; }
    }
}