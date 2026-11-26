using System.ComponentModel.DataAnnotations;
namespace Team.Api.Validation
{
    public class EstablishedDateAttribute: ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is not DateOnly date)
            {
                return false;
            }
            if (date == DateOnly.MinValue)
            {
                return false;
            }

            return date <= DateOnly.FromDateTime(DateTime.Today);
        }
    }
}
