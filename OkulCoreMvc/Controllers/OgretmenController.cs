using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Okul.BL.Abstract;
using Okul.BL.Concrete;
using Okul.Entity.Models;
using OkulCoreMvc.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkulCoreMvc.Controllers
{
    public class OgretmenController : Controller
    {
        private readonly IOgretmenService service;

        private readonly IBransService BransService;

        public OgretmenController(IOgretmenService service,IBransService bransService)
        {
            this.service = service;
            BransService = bransService;
        }
        public IActionResult Index()
        {

            var result = service.GetOgretmenByBrans();
            return View(result.ToList());
        }


        public IActionResult Create()
        {
            OgretmenCreateDTO ogrtmn = new OgretmenCreateDTO();

            var bransListesi= BransService.GetAll(null);
            SelectList selectbransListe = new SelectList(bransListesi,"Id", "BransAdi");
            ogrtmn.BransListesi = selectbransListe;
            return View(ogrtmn);
        }
        [HttpPost]
        public IActionResult Create(OgretmenCreateDTO dTO)
        {

            if (ModelState.IsValid)
            {
                Ogretmen ogretmen = new Ogretmen
                {
                    Ad = dTO.Ad,
                    Soyad = dTO.Soyad,
                    CepTelefonu = dTO.CepTelefonu,
                    TCKimlik = dTO.TCKimlik,
                    BransId = dTO.BransId,
                    Email = dTO.Email,
                    CreateDate = DateTime.Now,
                    Maas=dTO.Maas
                };

                service.Add(ogretmen);
                return RedirectToAction("Index");
            }
            else
            {

                ModelState.AddModelError("", "Lutfen gerekli yerleri doldurunuz..");

                return View(dTO);
            }

           
           
        }

        public IActionResult Edit(int id)
        {
            if (id == null && id <= 0)
            {
                return BadRequest();
            }

            var ogrtmn = service.Find(id);
            if (ogrtmn == null)
            {
                return NotFound();
            }

            return View(ogrtmn);
            
        }

        
        [HttpPost]
        public IActionResult Edit(Ogretmen ogretmen)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", $"Girilen Bilgilerde toplam {ModelState.ErrorCount} adet hata var");
                return View(ogretmen);
            }
            service.Update(ogretmen);

            return RedirectToAction("Index");
        }
    }
}
