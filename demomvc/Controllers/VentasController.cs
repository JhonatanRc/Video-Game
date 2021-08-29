using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
using demomvc.Data;

namespace demomvc.Controllers
{
    public class VentasController:Controller
    {
        private readonly ApplicationDbContext _context;
        
        public VentasController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Ventas objVentas)
        {
            _context.Add(objVentas);
            _context.SaveChangesAsync();

            ViewData["Message"] = "Se registró con exito, gracias";
            return View("index");
        }

    }
}