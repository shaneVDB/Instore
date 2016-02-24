using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shane.InStore.WebApi.Models
{
    public class Banking
    {
        public Guid Id { get; set; }
        public int Branch { get; set; }
        public DateTime FinPeriod { get; set; }
        public string EmployeeId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int TranType { get; set; }
        public string DocumentNumber { get; set; }
        public Double DocumentAmount { get; set; }
        public Double ComputedBank { get; set; }
        public Double ManualBank { get; set; }
        public Double VarianceBank { get; set; }
    }
}