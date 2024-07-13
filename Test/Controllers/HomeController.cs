using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Kendo.Mvc;
using Kendo.Mvc.UI;

namespace Test.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public JsonResult GetData([DataSourceRequest] DataSourceRequest request)
    {
        return Json(new { status = true, message = "OK" });
    }

    [HttpPost]
    public JsonResult InsertData(TestClass model)
    {
        return Json(new { status = true, message = "OK " + model.Id });
    }
}
public class TestClass
{
    public int Id { get; set; }
    public string Name { get; set; }
}

