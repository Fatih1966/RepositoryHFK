using Microsoft.AspNetCore.Mvc;
using Okul.BL.Abstract;
using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkulCoreMvc.Controllers
{
    public class SinifController : Controller
    {
        private readonly ISinifService service;

        public SinifController(ISinifService service)
        {

            this.service = service;
        }


        public IActionResult Index()
        {
            var result = service.GetAll(null);
            return View(result.ToList());
        }

        public IActionResult Detay(int id)
        {
            var result = service.SinifListesiGetir(id);
            return View(result.ToList());
        }

        public IActionResult Create()
        {
            Sinif sinif = new Sinif();

            return View(sinif);
        }

        [HttpPost]
        public IActionResult Create(Sinif model)
        {
            if (ModelState.IsValid)
            {
                service.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
