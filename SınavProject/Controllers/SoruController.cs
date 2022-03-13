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
            return View();
        }

        [HttpPost]
        public JsonResult Add(Soru soru)
        {
            return new JsonResult(1);
        }


        public IActionResult Add(int? id)
        {
            //id varsa getbyid ile soruyu dön
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
