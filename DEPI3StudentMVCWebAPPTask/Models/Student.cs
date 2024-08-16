using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI3StudentMVCWebAPPTask
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required!")]
        [MaxLength(50,ErrorMessage ="Max Length is 50 Chars")]
        [MinLength(4, ErrorMessage = "Min Length is 4 Chars")]
        public string? Name { get; set; }
        public string? ImgPath { get; set; }

        [RegularExpression(@"^[0-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{4,10}-[a-zA-Z]{5,10}$"
        , ErrorMessage ="Address must be like 123-Street-City-Country")]
        public string? Address { get; set; }
    }
}
