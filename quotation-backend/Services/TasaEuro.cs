using quotation_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace quotation_backend.Services
{
    public class TasaEuro : ITasaCotizacion
    {
        public async Task<Cotizar> GetTasa(HttpClient httpClient)
        {
            string requestEndpoint = $"EUR/{Parametro.claveApi}";

            Cotizar cotizar = null;
            HttpResponseMessage response = await httpClient.GetAsync(requestEndpoint);
            if (response.IsSuccessStatusCode)
            {
                ResultJson resultado = await response.Content.ReadAsAsync<ResultJson>();
                cotizar = new Cotizar { Moneda = Parametro.monedaEuro, Precio = (Math.Round(resultado.Result.Value, 1)) };
            }
            return cotizar;
        }
    }
}
