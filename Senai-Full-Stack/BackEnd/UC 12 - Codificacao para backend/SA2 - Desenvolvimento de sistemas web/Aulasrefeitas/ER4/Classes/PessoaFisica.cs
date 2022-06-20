using ER2.Interfaces;

namespace ER2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public DateTime ?dataNascimento { get; set; }
        
        
        
        
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double idade = (dataAtual - dataNasc).TotalDays/365.25;
            

            Console.WriteLine($"Número de Dias: {idade}");
            return true;
            
        }

        public override float PagarImposto(float rendimento){
            throw new NotImplementedException();
        }
    }
}