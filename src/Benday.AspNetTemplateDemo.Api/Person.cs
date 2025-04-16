using System.ComponentModel.DataAnnotations;

namespace Benday.AspNetTemplateDemo.Api;

public class Person
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Display(Name = "First Name")]
    public string FirstName { get; set; } = string.Empty;

    [Display(Name = "Last Name")]
    public string LastName { get; set; } = string.Empty;
    
    public List<Address> Addresses { get; set; } = new();

    [Display(Name = "Birth Date")]
    public DateTime BirthDate { get; set; } = DateTime.UtcNow;

    [Display(Name = "Height (in))")]
    public float HeightInInches { get; set; } = 69.549281f;

    [Display(Name = "Height (cm)")]
    public float HeightInCentimeters
    {
        get
        {
            return HeightInInches * 2.54f;
        }
    }
}
