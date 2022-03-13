using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SınavProject.Controllers
{
    public class SikController: Controller
    {
        private ISikService _sikService;

        public SikController(ISikService sikService)
        {
            _sikService = sikService;
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
