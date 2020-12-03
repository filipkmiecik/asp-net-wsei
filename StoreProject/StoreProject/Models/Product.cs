using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;


namespace StoreProject.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić nazwę produktu")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please wprowadzić opis produktu")]
        public string description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Proszę wprowadzić dodatnią cenę")]
        public decimal price { get; set; }
        [Required(ErrorMessage = "Please nadać kategorię")]
        public string category { get; set; }

    }
}
