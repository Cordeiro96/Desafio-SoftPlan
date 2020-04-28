using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalculoJuros.Aplicacao.Interface
{
    public interface ICalculoJurosAplicacao
    {
        decimal ObterCalculoJuros(decimal valorInicial, int meses);
    }
}