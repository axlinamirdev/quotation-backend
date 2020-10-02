using quotation_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace quotation_backend.Services
{
    public class TasaCotizarContext
    {
        private ITasaCotizacion _cotizacion;

        public TasaCotizarContext(ITasaCotizacion cotizacion) => _cotizacion = cotizacion;

        public async Task<Cotizar> GetTasa(HttpClient httpClient) => await _cotizacion.GetTasa(httpClient);

    }
}
