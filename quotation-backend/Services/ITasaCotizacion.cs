using quotation_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace quotation_backend.Services
{
    public interface ITasaCotizacion
    {
        Task<Cotizar> GetTasa(HttpClient httpClient);
    }
}
