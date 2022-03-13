using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SınavProject.Controllers
{
    public class SinavController: Controller
    {

        private ISinavService _sinavService;
        public SinavController(ISinavService sinavService)
        {
            _sinavService = sinavService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(Sinav sinav)
        {
            return View();
        }

        public IActionResult Update(Sinav sinav)
        {
            return View();
        }

        public IActionResult Delete(Sinav sinav)
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return View();
        }

    }
}
