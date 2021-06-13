using Microsoft.AspNetCore.Mvc;
using Okul.BL.Abstract;
using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkulCoreMvc.Controllers
{
    public class BransController : Controller
    {
        private readonly IBransService service;

        public BransController(IBransService service)
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
            var result = service.OgretmenListesiGetir(id);
            return View(result.ToList());
        }
        public IActionResult Create()
        {
            Brans br = new Brans();
            return View(br);
        }
        [HttpPost]
        public IActionResult Create(Brans br)
        {

            if (ModelState.IsValid)
            {
                br.CreateDate = DateTime.Now;
                service.Add(br);
                return RedirectToAction("Index");
            }
            return View(br);
        }

        public IActionResult Update(int id)
        {
            var br = service.Find(id);
            return View(br);
        }

        [HttpPost]
        public IActionResult Update(Brans br)
        {
            if (ModelState.IsValid)
            {
                
                service.Update(br);
                return RedirectToAction("Index");
            }
            return View(br);
        }
        public IActionResult Delete(int id)
        {
            var br = service.Find(id);
            return View(br);
        }

        [HttpPost]
        public IActionResult Delete(Brans br)
        {
            if (ModelState.IsValid)
            {

                service.Delete(br);
                return RedirectToAction("Index");
            }
            return View(br);
        }
    }
}
