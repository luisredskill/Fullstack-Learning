using ER2.Interfaces;

namespace ER2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}