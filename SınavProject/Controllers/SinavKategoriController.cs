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

        [HttpGet]
        public IActionResult Index()
        {
            var result = _sinavKategoriService.GetAll();
            if (result.Success)
            {
                return View();

            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult Add(SinavKategori sinavKategori)
        {
            var result = _sinavKategoriService.Add(sinavKategori);
            if (result.Success)
            {
            return View();

            }
            return BadRequest();
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
