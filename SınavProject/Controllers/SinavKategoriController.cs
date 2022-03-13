using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SınavProject.Controllers
{
    public class SinavKategoriController:Controller
    {

        private ISinavKategoriService _sinavKategoriService;
        public SinavKategoriController(ISinavKategoriService sinavKategoriService)
        {
            _sinavKategoriService = sinavKategoriService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(SinavKategori sinavKategori)
        {
            return View();
        }

        public IActionResult Update(SinavKategori sinavKategori)
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return View();
        }

        public IActionResult Delete(SinavKategori sinavKategori)
        {
            return View();
        }
    }
}
