using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Registration.Models
{
    public class Student
    {
        [Required(ErrorMessage="Please enter your name")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Please enter your age")]
        public String Age { get; set; }
        [Required(ErrorMessage = "Please choose if you are graduated or not")]
        public bool ? hasGranduate { get; set; } /* ? cho phép đáp án null*/
    }
}
