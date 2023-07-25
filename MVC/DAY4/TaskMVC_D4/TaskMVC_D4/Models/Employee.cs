using System;
using System.ComponentModel.DataAnnotations;
namespace TaskMVC_D4.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage ="Name is Required!")]
        [MaxLength(30 , ErrorMessage ="Max Length For Name is 30 chracater")]
        [Display(Name="Employee Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "User Name is Required!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is Required!")]
        [MinLength(8,ErrorMessage =("Password Must be at least 8 chracter"))]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is Required!")]
        [Compare("Password", ErrorMessage ="Password Not Matched!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Gender is Required!")]
        [RegularExpression("^(Male|Female)$",ErrorMessage ="Only Male Or Female")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Salary is Required!")]
        [Range(1000,10000)]
        public decimal Salary { get; set; }
        [Required(ErrorMessage = "JoinDate is Required!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime JoinDate { get; set; }
        [Required(ErrorMessage = "Email is Required!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "PhoneNumber is Required!")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

    }
}