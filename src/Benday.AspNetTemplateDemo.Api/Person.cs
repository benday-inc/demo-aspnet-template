namespace Benday.AspNetTemplateDemo.Api;

public class Person
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string FirstName { get; set; } = string.Empty;
    
    public string LastName { get; set; } = string.Empty;
    
    public List<Address> Addresses { get; set; } = new();
}
