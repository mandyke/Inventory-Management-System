using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }

        //[Required(ErrorMessage = "Please Enter The Password...")]
        //[DataType(DataType.Password)]
        //[Display(Name="Password")]
        //public string Pwd { get; set; }

        //[Required(ErrorMessage = "Please Enter The Confirm Password...")]
        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm Password")]
        //public string Confirmpwd { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
