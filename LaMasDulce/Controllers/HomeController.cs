// using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LaMasDulce.Models;
// using Microsoft.Extensions.Logging;

namespace LaMasDulce.Controllers;

public class HomeController : Controller
{
    private readonly LaMasDulceContext _db;

    public HomeController(LaMasDulceContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        return View();
    }
}
