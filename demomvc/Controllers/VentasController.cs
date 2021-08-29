using Microsoft.AspNetCore.Mvc;
using demomvc.Models;

namespace demomvc.Controllers
{
    public class VentasController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {

            
            ViewData["Message"] = "Se registró con exito, gracias";
            return View("index");
        }

    }
}