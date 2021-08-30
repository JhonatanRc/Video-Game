using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
using demomvc.Data;
using System.Linq;

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

            return View(_context.DataVentas.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ventas objVentas)
        {
            _context.Add(objVentas);
            _context.SaveChanges();

            ViewData["Message"] = "Se registró con exito, gracias";
            return View();
        }
        public IActionResult Edit(int id)
        {
            Ventas objVentas = _context.DataVentas.Find(id);
            if(objVentas == null){
                return NotFound();
            }
            return View(objVentas);
        }

        [HttpPost]

        public ActionResult Edit(int id, [Bind("Id,Name,Categoria,Precio,Descuento")] Ventas objVentas)
        {
            _context.Update(objVentas);
            _context.SaveChanges();
            ViewData["Message"] = "Se actualizó correctamente";
             return View(objVentas);
        }

        public IActionResult Delete(int id)
        {
            Ventas objVentas = _context.DataVentas.Find(id);
            _context.DataVentas.Remove(objVentas);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}