using Entities.Transformers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TagAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string tag = TagTransformer.Transform(value.ToString());

            validationContext
                .ObjectType
                .GetProperty(validationContext.MemberName)
                .SetValue(validationContext.ObjectInstance, tag, null);

            return ValidationResult.Success;
        }
    }
}
