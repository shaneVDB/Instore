using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shane.InStore.WebApi.Models
{
    public class BranchControl
    {
        public Guid Id { get; set; }
        public int BranchCode { get; set; }
        public DateTime FinPeriod { get; set; }
        public DateTime DateEnd { get; set; }
        public string ManagerAuth { get; set; }

    }
}