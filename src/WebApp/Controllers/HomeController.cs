using System.Diagnostics;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data.Contexts;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController : Controller 
{

    private readonly IUsuarioService _usuarioService;

    private readonly ILogger<HomeController> _logger;
    List<Usuario> listUSer = new List<Usuario>();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
       // _usuarioService = usuarioService;
    }
        

    public IActionResult Index()
        => View();

    public IActionResult Privacy()
        => View();

    [HttpPost]
    public IActionResult ValidaLogin([FromBody] Usuario user )
    {

        if(user == null)
        {
         //   return BadRequest();
            return View("/index");
        }

        return View("/Usuario/");
    }

    public IActionResult Usuario()
    {
        var usuario = new List<Usuario>();// _usuarioService.ListUsuario();
        return View(listUSer);  
    }

    [HttpPost]
    public IActionResult InsereUsuario([FromBody] Usuario user)
    {
        // _usuarioService.InsertUsuario(user);
        listUSer.Add(user);
        TempData["dados"] = listUSer;
        return View("~/Home/usuario.cshtml");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
        => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}