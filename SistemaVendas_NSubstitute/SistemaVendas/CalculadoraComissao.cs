using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaVendas
{
    public class CalculadoraComissao
    {
        public const decimal COMISSAO_FAIXA_2 = 6;

        public decimal CalculaValorTotalComissao(decimal valor_venda)
        {
            if (valor_venda > 10000)
            {
                return (valor_venda / 100) * COMISSAO_FAIXA_2;
            }
            else {
                return (valor_venda / 100) * 5;
            }
        }
    }
}
