using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaVendas
{
    public class CalculadoraRoyalties
    {
        private const decimal percentual_royalties = 0.20m;
        private IRepositorioVendas repositorioVendas;
        private CalculadoraComissao calculadoraComissao = new CalculadoraComissao();

        public CalculadoraRoyalties(IRepositorioVendas paramRepositorioVendas, CalculadoraComissao paramCalculadoraComissao)
        {
            this.repositorioVendas = paramRepositorioVendas;
            this.calculadoraComissao = paramCalculadoraComissao;
        }

        public decimal Calcular(int mes, int ano)
        {
                        
             List<decimal> listaVendas = repositorioVendas.GetVendas(mes, ano);
             decimal valorLiquido = 0m;

             foreach (var valorVenda in listaVendas)
             {
                 valorLiquido += (valorVenda - calculadoraComissao.CalculaValorTotalComissao(valorVenda)); 
             }

            return valorLiquido * percentual_royalties;
        }
    }
}
