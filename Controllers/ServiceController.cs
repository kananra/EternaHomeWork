using EternaHomeWork.DataAccess;
using EternaHomeWork.Models;
using EternaHomeWork.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EternaHomeWork.Controllers
{
    public class ServiceController : Controller
    {

        private readonly DataContext _context;
        public ServiceController(DataContext context)
        {
            _context = context;
        }

        public ViewResult Index()
        {
            List<Service> services = _context.Services.ToList();
            return View(services);
        }

        public ViewResult Detail(int id)
        {
            //Service service = Data.Services.Find(x => x.Id == id);
            Service service = _context.Services.Find(id);

            return View(service);
        }

    }
}
