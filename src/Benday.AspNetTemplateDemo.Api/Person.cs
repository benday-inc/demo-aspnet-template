using System.ComponentModel.DataAnnotations;

namespace Benday.AspNetTemplateDemo.Api;

public class Person
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Display(Name = "First Name")]
    public string FirstName { get; set; } = string.Empty;

    [Display(Name = "Last Name")]
    public string LastName { get; set; } = string.Empty;

    [Display(Name = "Email Address")]
    [EmailAddress]
    [Required]
    public string Email { get; set; } = string.Empty;

    [Display(Name = "Notes")]
    [DataType(DataType.MultilineText)]
    [StringLength(25, ErrorMessage = "The {0} must be at most {1} characters long.")]
    public string Notes { get; set; } = string.Empty;

    public List<Address> Addresses { get; set; } = new();

    [Display(Name = "Birth Date")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
    public DateTime BirthDate { get; set; } = DateTime.UtcNow;

    [Display(Name = "Height (in)")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:F2}")]
    public float HeightInInches { get; set; } = 69.549281f;

    [Display(Name = "Height (cm)")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:F2}")]
    public float HeightInCentimeters
    {
        get
        {
            return HeightInInches * 2.54f;
        }
    }
}
