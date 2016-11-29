using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppPrincipale.Validation
{
    public class NAS : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (((string)value).Length == 9)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Longueur Incorrecte");
            }
            

        }

    }
}