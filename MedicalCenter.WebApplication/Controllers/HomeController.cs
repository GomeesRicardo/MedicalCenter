using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MedicalCenter.WebApplication.Models;
using MedicalCenter.Infrastructure.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using MedicalCenter.DomainService.Interfaces;

namespace MedicalCenter.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPacienteService _pacienteService;

        public HomeController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        public async Task<IActionResult> Index()
        {
            var aaaa = _pacienteService.ReadAll();
            return View(aaaa.ToList());
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
