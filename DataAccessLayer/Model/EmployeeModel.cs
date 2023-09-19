using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer
{
    public class EmployeeModel
    {
        public EmployeeModel()
        {
            Type = new List<EmployeeDropDownModel>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       
        [Required]
        public string Dept { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public string DOB { get; set; }

        public string WorkType { get; set; }

        [NotMapped]
        public List<EmployeeDropDownModel> Type { get; set; }


    }
}
