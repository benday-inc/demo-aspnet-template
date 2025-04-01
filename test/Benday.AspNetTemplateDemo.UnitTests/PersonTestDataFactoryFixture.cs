using Benday.AspNetTemplateDemo.Api;
using Xunit.Abstractions;

namespace Benday.AspNetTemplateDemo.UnitTests;

public class PersonTestDataFactoryFixture  : TestBase
{
    public PersonTestDataFactoryFixture(ITestOutputHelper output) : base(output)
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

    [Fact]
    public void GetPersonList()
    {
        TestDataFactory factory = new TestDataFactory();

        var expected = 10;

        var data = factory.GetPersonList(expected);

        Assert.Equal(expected, data.Count);

        var json = System.Text.Json.JsonSerializer.Serialize(data, new System.Text.Json.JsonSerializerOptions()
        {
            WriteIndented = true
        });

        WriteLine(json);
    }
}
