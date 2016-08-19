using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using SistemaVendas;
using System.Collections.Generic;

namespace TesteVendas
{

    [TestClass]
    public class TesteCalculadoraRoyalties
    {
        CalculadoraComissao calculadoraComissao;
        IRepositorioVendas repVendas ;
            
        [TestInitialize]
        public void inicializarMocks()
        {
            calculadoraComissao = Substitute.For<CalculadoraComissao>();
            repVendas = Substitute.For<IRepositorioVendas>();
        }

        [TestMethod]
        public void Teste_Calcular_Royalty_Mes_Sem_Venda()
        {
            //variaveis
            int mes = 1;
            int ano = 2016;
            decimal esperado = 0M;

            repVendas.GetVendas(mes, ano).Returns(new List<decimal>());
            CalculadoraRoyalties calculadoraRoyalties = new CalculadoraRoyalties(repVendas, calculadoraComissao);
            decimal retorno = calculadoraRoyalties.Calcular(mes, ano);
            Assert.AreEqual(esperado, retorno);
        }


        [TestMethod]
        public void Teste_Calcular_Royalty_Mes_Com_1_Venda_10k()
        {
            //variaveis
            int mes = 1;
            int ano = 2016;
            decimal valorVenda = 10000M;
            List<decimal> listaVendas = new List<decimal>();
            listaVendas.Add(valorVenda);
            decimal esperado = 1900M;


            repVendas.GetVendas(mes, ano).Returns(listaVendas);
            calculadoraComissao.CalculaValorTotalComissao(valorVenda).Returns(500M);
            CalculadoraRoyalties calculadoraRoyalties = new CalculadoraRoyalties(repVendas, calculadoraComissao);
            decimal retorno = calculadoraRoyalties.Calcular(mes, ano);
            Assert.AreEqual(esperado, retorno);
        }
    }
}
