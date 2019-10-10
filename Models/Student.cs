using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidationAttrApp.Models
{
    public class Student
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Field 'First Name' should be filled in!")]
        public string FirstName { get; set; }

        [Display(Name = "Second Name")]
        [Required(ErrorMessage = "Field 'Second Name' should be filled in!")]
        public string SecondName { get; set; }

        [Display(Name = "Id Card Number")]
        [Required(ErrorMessage = "Field 'Id Card Number' should be filled in!")]
        [RegularExpression(@"[A-Z]{2}[0-9]{4}[A-Z]{1}", ErrorMessage = "Card Id has not correct format! Should be like AA5555B")]
        [Remote("CheckPassport", "Students", ErrorMessage = "Passport Id already available!")]
        public string PassportId { get; set; }

        [Display(Name = "Date of Birthday")]
        [Required(ErrorMessage = "Field 'Birthday' should be filled in!")]
        [RegularExpression(@"\d{4}\/(0[1-9]|1[012])\/(0[1-9]|[12][0-9]|3[01])", ErrorMessage = "Birthday should have format as yyyy/MM/dd")]
        [StudentsAgeValidation(ErrorMessage = "Sorry, but our students age should be between 15 and 40 years!!")] //Custom Validator
        public string Birthdate { get; set; }

        [Display(Name = "Postal Address")]
        [Required(ErrorMessage = "Field 'Postal Address' should be filled in!")]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email address is not correct")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Password should be between 6 to 10 digits!")]
        [RegularExpression(@"[A-Za-z0-9]+", ErrorMessage = "Password should include capital & small letters and numbers!")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Entered passwords are not the same..")]
        [Required(ErrorMessage = "Field 'Confirm Password' should be filled in!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Enterence Year")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "Year should be in format 'yyyy'")]
        public string EnterenceYear { get; set; }

        [Display(Name = "Description Group")]
        [RegularExpression(@"[A-Z]{2}[0-9]{4}", ErrorMessage = "Group shoud be in the following format - QQ1234")]
        public string GroupDescription { get; set; }
    }
}