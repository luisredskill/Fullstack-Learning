using ProjetoTeste;
using Xunit;

namespace TextXunit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparação/Organização
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;
            //Act - Ação/ Execução do teste
            var resultado = operacoes.Somar(pNum, sNum);
            //Assert - Verificação do resultao
            Assert.Equal(rNum, resultado);
        }
        [Theory]
        [InlineData(1, 1 , 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 1, 2)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act - Ação/ Execução do teste
            var resultado = operacoes.Somar(pNum, sNum);
            //Assert - Verificação
            Assert.Equal(rNum, resultado);
        }
    }
}