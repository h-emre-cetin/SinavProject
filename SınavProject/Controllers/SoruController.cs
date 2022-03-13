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
            return View();
        }
        public IActionResult Add(Soru soru)
        {
            return View();
        }

        public IActionResult Update(Soru soru)
        {
            return View();
        }

        public IActionResult Delete(Soru soru)
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return View();
        }
    }
}
