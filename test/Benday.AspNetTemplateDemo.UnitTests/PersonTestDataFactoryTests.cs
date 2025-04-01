using Benday.AspNetTemplateDemo.Api;
using Xunit.Abstractions;

namespace Benday.AspNetTemplateDemo.UnitTests;

public class PersonTestDataFactoryTests  : TestBase
{
    public PersonTestDataFactoryTests(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public void GetPerson()
    {
        TestDataFactory factory = new TestDataFactory();
        var person = factory.GetPerson();
        Assert.NotNull(person);

        // format json indented
        var json = System.Text.Json.JsonSerializer.Serialize(person, new System.Text.Json.JsonSerializerOptions()
        {
            WriteIndented = true
        });

        WriteLine(json);
    }
}
