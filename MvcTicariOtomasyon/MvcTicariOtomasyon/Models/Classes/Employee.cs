﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcTicariOtomasyon.Models.Classes
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string EmployeeName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string EmployeeLastName { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string EmployeeImage { get; set; }
        public SaleMovement SaleMovement { get; set; }
        public Department EmployeDepartment { get; set; }
       
    }
}