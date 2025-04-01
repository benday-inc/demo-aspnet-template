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

    public IActionResult Edit(string id)
    {
        var person = _TestDataFactory.TestData.FirstOrDefault(x => x.Id == id);

        if (person == null)
        {
            return NotFound();
        }
        else
        {
            return View(person);
        }
    }
}
