﻿using System.ComponentModel.DataAnnotations;

namespace Labb2API.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string  PhoneNumber { get; set; }
        public string Gender { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public string StreetAdress { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }

    }


}
