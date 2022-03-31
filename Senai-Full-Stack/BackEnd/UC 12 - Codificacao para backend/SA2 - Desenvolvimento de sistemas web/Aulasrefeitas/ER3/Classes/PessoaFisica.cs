using ER2.Interfaces;

namespace ER2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public DateTime ?dataNascimento { get; set; }
        
        
        
        
        public void ValidarDataNascimento()
        {
            DateTime dataAtual = DateTime.Today;
            Console.WriteLine($"{dataAtual}");        
        }

        public override float PagarImposto(float rendimento){
            throw new NotImplementedException();
        }
    }
}