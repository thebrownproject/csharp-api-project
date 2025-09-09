using System.ComponentModel.DataAnnotations;


public class AllowedValuesAttribute : ValidationAttribute
{
    private string[] _allowedValues;

    public AllowedValuesAttribute(string[] allowedValues)
    {
        _allowedValues = allowedValues;
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult("Value is required");
        }

        if (!_allowedValues.Contains(value.ToString()))
        {
            return new ValidationResult($"Value must be one of: {string.Join(", ", _allowedValues)}");
        }

        return ValidationResult.Success;
    }
}