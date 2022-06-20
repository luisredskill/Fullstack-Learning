using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TesteXunit.Controller
{
    internal class LoginControllerTeste
    {
        [Fact]
        public void LoginController_Retornar_Usuario_Invalido()
        {
            // Arrange
            var fakeRepository = new Mock<IUsuarioRepository>();
        }
    }
}
