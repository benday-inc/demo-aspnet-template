using Benday.AspNetTemplateDemo.Api;
using Microsoft.AspNetCore.Mvc;

namespace Benday.AspNetTemplateDemo.WebUi.Controllers;
public class PersonController : Controller
{
    private readonly TestDataFactory _TestDataFactory;

    public PersonController(TestDataFactory testDataFactory)
    {
        _TestDataFactory = testDataFactory;
    }

    // get list of people
    public IActionResult Index()
    {
        return View(_TestDataFactory.TestData);
    }
}
