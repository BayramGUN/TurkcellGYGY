using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DILifeTime.Models;

namespace DILifeTime.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ISingletonGuid _singleton;
    private readonly IScopedGuid _scoped;
    private readonly ITransientGuid _transient;
    private readonly GuidService _guidService;
    public HomeController(
        ILogger<HomeController> logger,
        ISingletonGuid singleton,
        IScopedGuid scoped,
        ITransientGuid transient,
        GuidService guidService
    )
    {
        _logger = logger;
        _transient = transient;
        _scoped = scoped;
        _singleton = singleton;
        _guidService = guidService;
    }

    public IActionResult Index()
    {
        //var singleton = new Singleton();
        ViewBag.Singleton = _singleton.Guid.ToString();
        ViewBag.Transient = _transient.Guid.ToString();
        ViewBag.Scoped = _scoped.Guid.ToString();

        ViewBag.SingletonService = _guidService.Singleton.Guid.ToString();
        ViewBag.TransientService = _guidService.Transient.Guid.ToString();
        ViewBag.ScopedService = _guidService.Scoped.Guid.ToString();
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
}
