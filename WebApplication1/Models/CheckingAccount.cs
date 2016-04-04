using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Account must be between 6 and 10 characters")]
        //[RegularExpression(@"\D{6,10}", ErrorMessage = "Account must be between 6 and 10 characters")]
        [Display(Name="Account #")]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Name
        {
            get { return string.Format("{0} {1}", this.FirstName, this.LastName); }
        }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
    }
}