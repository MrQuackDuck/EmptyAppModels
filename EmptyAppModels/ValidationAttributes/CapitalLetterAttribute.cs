using System.ComponentModel.DataAnnotations;

namespace EmptyAppModels.ValidationAttributes;

public class CapitalLetterAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is null)
        {
            return false;
        }
        
        return value.ToString()[0] == Char.Parse(value.ToString()[0].ToString().ToUpper());
    }
}