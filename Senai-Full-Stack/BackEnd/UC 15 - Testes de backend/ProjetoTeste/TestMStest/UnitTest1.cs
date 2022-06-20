using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTeste;

namespace TestMStest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparação/Organização
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;
            //Act - Ação/ Execução do teste
            var resultado = operacoes.Somar(pNum, sNum);
            //Assert - Verificação do resultao
            Assert.AreEqual(rNum, resultado);
        }
        //--------------- refazendo o mesmo método
        //Arrange - Preparação/Organização
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 2)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act - Ação/ Execução do teste
            var resultado = operacoes.Somar(pNum, sNum);
            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }
    }
}