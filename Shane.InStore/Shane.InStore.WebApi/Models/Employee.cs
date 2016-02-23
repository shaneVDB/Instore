using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shane.InStore.WebApi.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public int Branch { get; set; }

        [Required]
        [StringLength(6, ErrorMessage = "Employee Number too long.")]
        public string EmployeeId { get; set; }

        [Required]
        public string EmployeeName { get; set; }
        
    }
}