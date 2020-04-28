using CalculoJuros.Aplicacao.Interface;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CalculoJuros.Aplicacao.App
{
    public class CalculoJurosAplicacao : ICalculoJurosAplicacao
    {
        public async Task<int> ObterTaxaJuros()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetStringAsync("http://localhost:60587/api/TaxaJuros");

            return Convert.ToInt32(response);
        }

        public decimal ObterCalculoJuros(decimal valorInicial, int meses)
        {
            var juros = Convert.ToDecimal(ObterTaxaJuros().GetAwaiter().GetResult());

            juros = juros / 100m;

            var soma = Convert.ToDouble(1 + Convert.ToDecimal(juros));
            var valor = valorInicial * Convert.ToDecimal(Math.Pow(soma, meses));
            return Math.Truncate(valor * 100) / 100;
        }
    }
}
