using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NovaTech.Data;
using NovaTech.Models;
using Microsoft.EntityFrameworkCore;
using NovaTech.ViewModels;

namespace NovaTech.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        HomeVM home = new()
        {
            Categorias = _context.Categorias.ToList(),
            Produtos = _context.Produtos
                .Include(p => p.Categoria)
                .ToList()
        };
        return View(home);
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
        Produto produto = _context.Produtos
            .Where(p => p.Id == id)
            .Include(pt => pt.Categoria)
            .SingleOrDefault();
        DetailsVM details = new()
        {
            Atual = produto,
        };
        return View(produto);
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
