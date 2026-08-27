using System.ComponentModel.DataAnnotations;

namespace ModelValidationsExample.Models
{
    public class Person
    {
        [Required (ErrorMessage = "{0} can't be empty or null ")]
        [Display(Name = "Person Name")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} must be between {2} and {1}" +
        "characters")]
        public string? PersonName { get; set; }

        [EmailAddress(ErrorMessage = "{0} is not a valid email address")]
        [Required (ErrorMessage = "{0} must provide email address")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "{0} is not a valid phone number")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "{0} can't be empty or null")]
        public string? Password { get; set; }
        [Required (ErrorMessage = "{0} can't be empty or null")]
        [Compare("Password", ErrorMessage = "{0} and {1} do not match")]
        public string? ConfirmPassword { get; set; }

        [Range(0, 1000, ErrorMessage = "{0} must be between ${1} and ${2}")]
        public double? Price { get; set; }

        public override string ToString()
        {
            return $"PersonName: {PersonName}, Email: {Email}, Phone: {Phone}," +
                $"Password: {Password}, ConfirmPassword: {ConfirmPassword}," +
                $"Price: {Price}";
        }
    }
}
