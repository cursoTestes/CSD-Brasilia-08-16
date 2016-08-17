using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaVendas;

namespace TesteVendas
{
    [TestClass]
    public class TesteCalculoComissao
    {
       [TestMethod]
        public void Teste_entrando_com_100k_retorna_6k()
        {
           //variaveis Assert
            decimal valor_venda = 100000;
            decimal valor_esperado = 6000;

           //chama o metodo Act
            CalculadoraComissao calculadoraComissao = new CalculadoraComissao();
            decimal retorno = calculadoraComissao.CalculaValorTotalComissao(valor_venda);

            Assert.AreEqual(valor_esperado, retorno);
        }

       [TestMethod]
       public void Teste_entrando_com_9999_retorna_499Reaise95cents()
       {
           //variaveis Assert
           decimal valor_venda = 9999;
           decimal valor_esperado = 499.95M;

           //chama o metodo Act
           CalculadoraComissao calculadoraComissao = new CalculadoraComissao();
           decimal retorno = calculadoraComissao.CalculaValorTotalComissao(valor_venda);

           Assert.AreEqual(valor_esperado, retorno);
       }

       [TestMethod]
       public void Teste_entrando_com_10k_retorna_500()
       {
           //variaveis Assert
           decimal valor_venda = 10000;
           decimal valor_esperado = 500;

           //chama o metodo Act
           CalculadoraComissao calculadoraComissao = new CalculadoraComissao();
           decimal retorno = calculadoraComissao.CalculaValorTotalComissao(valor_venda);

           Assert.AreEqual(valor_esperado, retorno);
      }

    }
}
