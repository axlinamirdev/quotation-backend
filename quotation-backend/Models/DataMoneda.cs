using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quotation_backend.Models
{
    public class DataMoneda
    {
        public DateTime Updated { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public Decimal Value { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Amount { get; set; }
    }
}
