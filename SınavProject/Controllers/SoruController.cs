using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SınavProject.Controllers
{
    public class SoruController: Controller
    {

        private ISoruService _soruService;
        public SoruController(ISoruService soruService)
        {
            _soruService = soruService;
        }

        public IActionResult Index()
        {
            //Soru kategorileri çekilecek
            //List<SinavKategori> soruKategoriler =
            //return View(soruKategoriler);
            var result = _soruService.GetAll();
            if (result.Success)
            {
                return View();
            }
            return BadRequest();
            
        }

        [HttpPost]
        public JsonResult Add(Soru soru)
        {
            var result = _soruService.Add(soru);
            if (result.Success)
            {
                return new JsonResult(1);
            }
            return new JsonResult(2);
        }


        public IActionResult Add(int? id)
        {
        
            return View();
        }

        public IActionResult Update(Soru soru)
        {
            return View();
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            return new JsonResult(1);
        }

        public IActionResult GetAll()
        {
            return View();
        }
    }
}
