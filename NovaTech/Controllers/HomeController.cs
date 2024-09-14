using System.Diagnostics;
			using Microsoft.AspNetCore.Mvc;
			using Microsoft.EntityFrameworkCore;
			using NovaTech.Data;
			using NovaTech.Models;
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
					HomeVM home = new() {
						Categorias = _context.Categorias.ToList(),
						Produtos = _context.Produtos
							.Include(p => p.Categorias)
							.ThenInclude(t => t.Categorias)
							.ToList(),
					};
					return View(home);
				}

				public IActionResult Details(int id)
				{
					Produtos produto = _context.Produtos
									.Where(p => p.Id == id)
									.Include(p => p.Categorias)
									.ThenInclude(t => t.Tip)
									.Include(p => p.Regiao)
									.Include(p => p.Genero)
									.SingleOrDefault();
					
					DetailsVM detailsVM = new()
					{
						Atual = produto,
						Anterior = _context.Produtos
							.OrderByDescending(p => p.Id)
							.FirstOrDefault(p => p.Id < id),
						Proximo = _context.Produtos
							.OrderBy(p => p.Id)
							.FirstOrDefault( p => p.Id > id)
					};
					
					return View(detailsVM);
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
