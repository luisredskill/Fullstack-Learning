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
            //Arrange - Prepara��o/Organiza��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;
            //Act - A��o/ Execu��o do teste
            var resultado = operacoes.Somar(pNum, sNum);
            //Assert - Verifica��o do resultao
            Assert.AreEqual(rNum, resultado);
        }
        //--------------- refazendo o mesmo m�todo
        //Arrange - Prepara��o/Organiza��o
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 2)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act - A��o/ Execu��o do teste
            var resultado = operacoes.Somar(pNum, sNum);
            //Assert - Verifica��o
            Assert.AreEqual(rNum, resultado);
        }
    }
}