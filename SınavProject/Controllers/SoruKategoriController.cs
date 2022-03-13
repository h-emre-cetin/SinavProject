using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SınavProject.Controllers
{
    public class SoruKategoriController: Controller
    {
        private ISoruKategoriService _soruKategoriService;
        public SoruKategoriController(ISoruKategoriService soruKategoriService)
        {
            _soruKategoriService = soruKategoriService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
