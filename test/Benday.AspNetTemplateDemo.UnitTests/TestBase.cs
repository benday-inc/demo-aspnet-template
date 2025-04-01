using Xunit.Abstractions;

namespace Benday.AspNetTemplateDemo.UnitTests;

public abstract class TestBase
{
    private readonly ITestOutputHelper _Output;

    public TestBase(ITestOutputHelper output)
    {
        _Output = output;
    }

    protected void WriteLine(string message)
    {
        _Output.WriteLine(message);
    }
}
