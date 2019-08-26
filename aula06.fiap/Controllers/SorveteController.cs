using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula06.fiap.Models;
using Microsoft.AspNetCore.Mvc;

namespace aula06.fiap.Controllers
{
    public class SorveteController : Controller
    {
        private static IList<Sorvete> _listarSorvetes = new List<Sorvete>();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Sorvete sorvete)
        {
            _listarSorvetes.Add(sorvete);
            TempData["msg"] = "Cadastrado";
            return RedirectToAction("Listar");
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return View(_listarSorvetes);
        }
    }
}