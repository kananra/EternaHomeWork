using EternaHomeWork.DataAccess;
using EternaHomeWork.Models;
using EternaHomeWork.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EternaHomeWork.Controllers
{
    public class ServiceController : Controller
    {
        public ViewResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Services = Data.Services
            };
            return View(vm);
        }


        public ViewResult Detail(int id)
        {
            List<Service> service = Data.Services;

            Service serv = service.Find(x => x.Id == id);


            return View(serv);
        }
    }
}
