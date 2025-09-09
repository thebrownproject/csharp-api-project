using System.ComponentModel.DataAnnotations; // Import validation framework

namespace Supabase_Minimal_API.Validation; // Define namespace

public class ValidationStringLengthAttribute : ValidationAttribute // Custom validation attribute
{
    private int _allowedLength; // Maximum allowed string length
    private string _columnName; // Column name for error messages

    public ValidationStringLengthAttribute( string columnName, int allowedLength) // Constructor
    {
        _columnName = columnName; // Store column name
        _allowedLength = allowedLength; // Store max length
    }

    // Validation method
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext) 
    {
        if (value == null) // Check for null value
            return new ValidationResult("No value given");

        string? stringValue = value as string; // Cast to string
        if (stringValue == null) // Check if cast failed
            return new ValidationResult("Value is not a string");

        if (stringValue.Length > _allowedLength) // Check length limit
            return new ValidationResult($"Value for {_columnName} is too long");

        return ValidationResult.Success; // All checks passed
    }
}
