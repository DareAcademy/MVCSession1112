using System.ComponentModel.DataAnnotations;

namespace MVCSession1112.helpers
{
    public class BDateValidation:ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //validation logic

            if (value != null)
            {
                if (Convert.ToDateTime(value) <= DateTime.Now)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Date should be less than or equal to current date");
                }
            }
            else {
                return new ValidationResult("BirthDate is required");
            }

            
        }
    }
}
