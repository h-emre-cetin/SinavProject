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

        [HttpGet]
        public IActionResult Index()
        {
            var result = _sinavService.GetAll();
            if (result.Success)
            {
                return View();
            }
            return BadRequest();
             
        }

        [HttpPost]
        public IActionResult Add(Sinav sinav)
        {
            var result = _sinavService.Add(sinav);
            if (result.Success)
            {
                return View();
            }

            return BadRequest();
            
        }

        [HttpPost]
        public IActionResult Update(Sinav sinav)
        {
            var result = _sinavService.Update(sinav);
            if (result.Success)
            {
                return View();
            }
            return BadRequest();
        }

        public IActionResult Delete(Sinav sinav)
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _sinavService.GetAll();
            if (result.Success)
            {
                return View();
            }
            return BadRequest();
        }

    }
}
