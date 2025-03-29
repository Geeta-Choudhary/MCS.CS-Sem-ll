using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}

