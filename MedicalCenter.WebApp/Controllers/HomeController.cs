using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MedicalCenter.WebApp.Models;
using MedicalCenter.Infrastructure.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MedicalCenter.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MedicalCenterContext _context;

        public HomeController()
        {
            MedicalCenterContext context = new MedicalCenterContext();
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Pacientes.ToListAsync());
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
