using Business.Abstract;
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

    }
}
