using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DynamicDropDownListInMVC.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Country { get; set; } 
    }
}