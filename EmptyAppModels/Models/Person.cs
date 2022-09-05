using System.ComponentModel.DataAnnotations;
using EmptyAppModels.ValidationAttributes;

namespace EmptyAppModels.Models;

public class Person
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(maximumLength: 20, MinimumLength = 2, 
        ErrorMessage = "The length of the name must be between 2 and 20 characters.")]
    [CapitalLetter(ErrorMessage = "Name must start from capital letter!")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Age is required")]
    [Range(16, 120, ErrorMessage = "Age must be between 16 and 120 years")]
    public int Age { get; set; }
    
    [Required]
    public string Password { get; set; }
    [Required]
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    public string PasswordConfirm { get; set; }

    public Person() { }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString() => $"{Name} - {Age}";
    }