using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Maths.Models
{
    public class Solve
    {
        [Display(Name = "Enter your First Number")]
        [Required(ErrorMessage = "Enter a valid number")]
        public string firstNumber { get; set; }
        [Display(Name = "Enter your Second Number")]
        [Required(ErrorMessage = "Enter a valid number")]
        public string secondNumber { get; set; }
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
    }
}