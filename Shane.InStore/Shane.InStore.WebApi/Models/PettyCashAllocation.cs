using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shane.InStore.WebApi.Models
{
    public class PettyCashAllocation
    {
        public Guid Id { get; set; }
        public PettyCash PettyCash { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime DocumentDate { get; set; }
        public int TranType { get; set; }
        public int SubCode { get; set; }
        public string EmployeeId { get; set; }
        public Double AllocationAmount { get; set; }
        public Double AllocationTax { get; set; }
        public string AllocateEmployeeName { get; set; }
        public string PettyCashType { get; set; }
        public bool IsReversed { get; set; }
        public DateTime ReversedDate { get; set; }
        public string ReversedDocumentNumber { get; set; }
        public string ReverseAuthCode { get; set; }
        }
}