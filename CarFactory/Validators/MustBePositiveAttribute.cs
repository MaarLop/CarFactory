using System.ComponentModel.DataAnnotations;

namespace Modules.CarFactory.Validators
{
    public class MustBePositiveAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (!int.TryParse((string)value, out var number))
            {
                return false;
            }

            return number > 0;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"{name} must be a positive number.";
        }
    }
}