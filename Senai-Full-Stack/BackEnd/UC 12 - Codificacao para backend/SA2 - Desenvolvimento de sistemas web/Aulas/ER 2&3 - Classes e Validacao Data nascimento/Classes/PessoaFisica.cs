using Cadastro_Pessoa.Interfaces;

namespace Cadastro_Pessoa.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf { get; set; }

        public string? dataNascimento { get; set; }


        public Int16 ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {

                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return 0;
                }
                return 1;

            }
            return 2;
        }

        public override float PagarImposto(float rendimento)
        {
             throw new NotImplementedException();
        }
    }
}