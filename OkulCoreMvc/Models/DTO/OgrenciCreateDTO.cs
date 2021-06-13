using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OkulCoreMvc.Models.DTO
{
    public class OgrenciCreateDTO
    {


        [Required(ErrorMessage = "Ogrenci Numarasi Zorunludur")]
        [StringLength(15, ErrorMessage = "Bu Alan 3-15 karakter arasinda olmalidir..", MinimumLength = 3)]
        [DataType(DataType.Text)]
        [DisplayName("Ogrenci Numarasi")]
        public string OgrenciNo { get; set; }

        [Required(ErrorMessage ="Ad Alani Zorunludur")]
        [StringLength(15,ErrorMessage ="Isim Alani 3-15 karakter arasinda olmalidir..",MinimumLength =3)]
        [DataType(DataType.Text)]
        [DisplayName("Adi")]

        public string Ad { get; set; }


        [Required(ErrorMessage = "Soyad Alani Zorunludur")]
        [StringLength(15, ErrorMessage = "Soyad Alani 2-15 karakter arasinda olmalidir..", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [DisplayName("Soyadi")]

        public string Soyad { get; set; }

        [Required(ErrorMessage = "Email Alani Zorunludur")]
        [StringLength(100, ErrorMessage = "Email Alani 5-15 karakter arasinda olmalidir..", MinimumLength = 5)]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Adresi")]

        public string Email { get; set; }


        [Required(ErrorMessage = "Telefon Alani Zorunludur")]
        [StringLength(100, ErrorMessage = "Telefon Alani 10-15 karakter arasinda olmalidir..", MinimumLength = 10)]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Cep Telefonu")]

        public string CepTelefonu { get; set; }


        [Required(ErrorMessage = "Tckimlik Alani Zorunludur")]
        [StringLength(11, ErrorMessage = "TcKimlik Alani 11 olmalidir..", MinimumLength = 11)]
        [DataType(DataType.Text)]
        [DisplayName("Tc Kimlik No")]

        public string TCKimlik { get; set; }


        [Required(ErrorMessage = "Sinif Alani Zorunludur")]
        [DataType(DataType.Text)]
        [DisplayName("Sinif ")]

        public int SinifId { get; set; }

        public SelectList SinifListesi { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime CreateDate { get; set; } 
    }
}
