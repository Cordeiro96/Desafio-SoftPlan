using CalculoJuros.Aplicacao.App;
using System;
using Xunit;

namespace CalculoJuros.Test
{
    public class CalculoJurosAplicacaoTest
    {
        [Fact]
        public void TaxaJuros()
        {
            int taxaJuros = 1;

            var calculoJurosAplicacao = new CalculoJurosAplicacao();

            var result = calculoJurosAplicacao.ObterTaxaJuros().GetAwaiter().GetResult();

            Assert.Equal(taxaJuros, result);
        }

        [Fact]
        public void CalculoJuros()
        {
            decimal valorInicial = 5;
            int meses = 6;

            var soma = Convert.ToDouble(1 + 0.01);
            var valor = valorInicial * Convert.ToDecimal(Math.Pow(soma, meses));
            var teste = Math.Truncate(valor * 100) / 100;

            var calculoJurosAplicacao = new CalculoJurosAplicacao();

            var result = calculoJurosAplicacao.ObterCalculoJuros(valorInicial, meses);

            Assert.Equal(teste, result);
        }
    }
}
