using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazaPerros.Models.ViewModels;
using RazaPerros.Repositories;

namespace RazaPerros.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            RazasRepository repos = new RazasRepository();
            IndexViewModel vm = new IndexViewModel();
            vm.Razas = repos.GetRazas();
            return View(vm);
        }

        public IActionResult Agregar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Eliminar()
        {
            return View();
        }
    }
}
