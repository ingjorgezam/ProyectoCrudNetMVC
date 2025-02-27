using System.Diagnostics;
using CrudNetMVC.Datos;
using CrudNetMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudNetMVC.Controllers
{

    public class InicioController : Controller
    {
        private readonly ILogger<InicioController> _logger;

		private readonly ApplicationDbContext _contexto;

		public InicioController(ApplicationDbContext contexto, ILogger<InicioController> logger)
        {
            _contexto = contexto;
            _logger = logger;

        }

		[HttpGet]
		public async Task<IActionResult> Index()
        {
            return View(await _contexto.Contacto.ToListAsync());
        }

        [HttpGet]
		public IActionResult Crear()
		{
			return View();
		}

		[HttpPost]
        [ValidateAntiForgeryToken]
		public async Task<IActionResult> Crear(Contacto contacto)
		{
            if (ModelState.IsValid)
			{
                //Agregar fecha y hora actual
                contacto.FechaCreacion=DateTime.Now;

                _contexto.Contacto.Add(contacto);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

			}

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
}