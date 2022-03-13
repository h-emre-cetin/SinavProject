using Business.Abstract;
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
    }
}
