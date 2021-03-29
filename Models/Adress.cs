using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fizzbuzzwebowo.Models
{
    public class Adress
    {
        [Display(Name = "Numer")]
        [Range(0, 1000), Required(ErrorMessage = "Pole jest obowiązkowe")]
        public int Number { get; set; }

        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [Display(Name = "Komunikat")]
        public string Ocena { get; set; }
    }
}
