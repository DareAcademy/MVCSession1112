using MVCSession1112.helpers;
using System.ComponentModel.DataAnnotations;

namespace MVCSession1112.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Mandetory!")]
        public string Name { get; set; }

        [RegularExpression(@"07(7|8|9)\d{7}")]
        //[StringLength(10,MinimumLength =7)]
        public string Phone { get; set; }

        [Range(500,1000)]
        public double amount { get; set; }

        public string Password { get; set; }

        [Compare("Password")]
        public string Confirm { get; set; }

        [BDateValidation]
        public DateTime BDate { get; set; }

    }
}
