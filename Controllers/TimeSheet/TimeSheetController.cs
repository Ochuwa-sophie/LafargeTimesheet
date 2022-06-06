using System.Diagnostics;
using LafargeTimesheet.Models;
using Microsoft.AspNetCore.Mvc;

namespace LafargeTimesheet.Controllers;

public class TimeSheetController : Controller
{
        private readonly ILogger<TimeSheetController> _logger;

    public TimeSheetController(ILogger<TimeSheetController> logger)
    {
        _logger = logger;
    }

    public IActionResult TimeSheet()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
