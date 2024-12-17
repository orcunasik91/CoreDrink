using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreDrink.WebUI.Data.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderLines { get; set; }

        [Display(Name ="Adı")]
        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz!")]
        public string FirstName { get; set; }

        [Display(Name = "Soyadı")]
        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz!")]
        public string LastName { get; set; }

        [Display(Name = "Adres1")]
        [StringLength(100)]
        [Required(ErrorMessage = "Lütfen Adresinizi Giriniz!")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Display(Name = "Posta Kodu")]
        [StringLength(10,MinimumLength = 5)]
        [Required(ErrorMessage = "Lütfen Posta Kodu Giriniz!")]
        public string ZipCode { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen Şehrinizi Giriniz!")]
        public string City { get; set; }

        [StringLength(10)]
        public string State { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen Ülkenizi Giriniz!")]
        public string Country { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Lütfen Telefon Numaranızı Giriniz!")]
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "E-posta adresi doğru biçimde girilmemiştir.")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
