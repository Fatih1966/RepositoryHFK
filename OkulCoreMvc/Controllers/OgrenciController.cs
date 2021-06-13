using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Okul.BL.Abstract;
using Okul.Entity.Models;
using OkulCoreMvc.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkulCoreMvc.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly IOgrenciService service;

        private readonly ISinifService SinifService;

        public OgrenciController(IOgrenciService service,ISinifService sinifService)
        {
            this.service = service;
            SinifService = sinifService;
        }
        public IActionResult Index()
        {

            var result = service.GetOgrenciBySinif();
            return View(result.ToList());
        }


        public IActionResult Create()
        {
            OgrenciCreateDTO ogr = new OgrenciCreateDTO();

            var sinifListesi= SinifService.GetAll(null);
            SelectList selectsinifListe = new SelectList(sinifListesi,"Id", "SinifAdi");
            ogr.SinifListesi = selectsinifListe;
            return View(ogr);
        }
        [HttpPost]
        public IActionResult Create(OgrenciCreateDTO dTO)
        {

            if (ModelState.IsValid)
            {
                Ogrenci ogrenci = new Ogrenci
                {
                    Ad = dTO.Ad,
                    Soyad = dTO.Soyad,
                    CepTelefonu = dTO.CepTelefonu,
                    TCKimlik = dTO.TCKimlik,
                    SinifId = dTO.SinifId,
                    Email = dTO.Email,
                    CreateDate = DateTime.Now,
                    OgrenciNo = dTO.OgrenciNo
                };

                service.Add(ogrenci);
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

            var ogr = service.Find(id);
            if (ogr == null)
            {
                return NotFound();
            }

            return View(ogr);
            
        }

        
        [HttpPost]
        public IActionResult Edit(Ogrenci ogrenci)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", $"Girilen Bilgilerde toplam {ModelState.ErrorCount} adet hata var");
                return View(ogrenci);
            }
            service.Update(ogrenci);

            return RedirectToAction("Index");
        }
    }
}
