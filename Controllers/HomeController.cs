using EternaHomeWork.DataAccess;
using EternaHomeWork.Models;
using EternaHomeWork.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EternaHomeWork.Controllers
{
    public class HomeController : Controller
    {
       

        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        public ViewResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Features = _context.Features.ToList(),
                Services= _context.Services.ToList(),
                Sliders = _context.Sliders.ToList()
            };

            return View(vm);
        }


        public ViewResult About()
        {
            return View();
        }


        public ViewResult Contact()
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
