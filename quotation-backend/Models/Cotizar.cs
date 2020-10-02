using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace quotation_backend.Models
{
    public class Cotizar
    {
        public string Moneda { get; set; }
        public decimal Precio { get; set; }
    }
}
