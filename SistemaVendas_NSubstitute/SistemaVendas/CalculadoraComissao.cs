using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaVendas
{
    public class CalculadoraComissao
    {
        public const decimal VALOR_LIMITE_COMISSAO = 10000;
        public const decimal COMISSAO_FAIXA_1 = 0.05m;
        public const decimal COMISSAO_FAIXA_2 = 0.06m;

        public virtual decimal CalculaValorTotalComissao(decimal valor_venda)
        {
            if (valor_venda > VALOR_LIMITE_COMISSAO)
            {
                return (valor_venda  * COMISSAO_FAIXA_2 );
            }
            else {
                return (valor_venda * COMISSAO_FAIXA_1);
            }
        }
    }
}
