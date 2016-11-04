using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UsersDbContext.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EmailValidatorAttribute : ValidationAttribute
    {
        private const string Pattern = "\\b(?<=\\s|^)([a-z0-9]+(?:[_.-]" +
        "[a-z0-9]+)*@[a-z]+\\-?[a-z]+(?:\\.[a-z]+)+)\\b";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!Regex.IsMatch((string)value, Pattern))
            {
                throw new ArgumentException("Invalid email!");
            }

            return ValidationResult.Success;

        }
    }
}
