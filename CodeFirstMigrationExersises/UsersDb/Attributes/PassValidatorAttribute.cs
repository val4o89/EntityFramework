using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersDbContext.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PassValidatorAttribute : ValidationAttribute
    {
        private char[] validChars = new char[] { '!', '@', '#', '$', '%', '^', '&', '*'
            , '(', ')', '_', '+', '<', '>', '?' };

        private string userPassword = string.Empty;

        private int minLength;

        private int maxLength;

        public PassValidatorAttribute(int minLength = 0, int maxLength = int.MaxValue)
        {
            this.minLength = minLength;
            this.maxLength = maxLength;
        }

        public bool ContainsLowerCase { get; set; }
        public bool ContainsUpperCase { get; set; }
        public bool ContainsDigit { get; set; }
        public bool ContainsSpecialSimbol { get; set; }


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            this.userPassword = (string)value;

            if (this.userPassword.Length < this.minLength || this.userPassword.Length > this.maxLength)
            {
                throw new ArgumentException("Invalid password length!");
            }

            if (this.userPassword.IndexOfAny(validChars) == -1 && this.ContainsSpecialSimbol == true)
            {
                throw new ArgumentException("Pass does not contains a special character!");
            }

            if (!userPassword.Any(char.IsDigit) && this.ContainsDigit == true)
            {
                throw new ArgumentException("Pass does not contains a digit!");
            }
            if (!userPassword.Any(char.IsLower) && this.ContainsLowerCase == true)
            {
                throw new ArgumentException("Pass does not contains a lower letter!");
            }
            if (!userPassword.Any(char.IsUpper) && this.ContainsUpperCase == true)
            {
                throw new ArgumentException("Pass does not contains a upper letter!");
            }

            return ValidationResult.Success;
        }
    }
}
