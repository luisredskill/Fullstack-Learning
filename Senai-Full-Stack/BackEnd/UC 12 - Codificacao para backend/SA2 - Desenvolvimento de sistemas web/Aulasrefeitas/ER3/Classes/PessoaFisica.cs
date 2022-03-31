using ER2.Interfaces;

namespace ER2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public DateTime ?dataNascimento { get; set; }
        
        
        
        
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Now;
            TimeSpan subtração = (dataAtual - dataNasc);
            double anos = (dataAtual - dataNasc).TotalDays; 
            

            Console.WriteLine($"TimeSpan: {subtração} double: {anos}");
            return true;
            
        }

        public override float PagarImposto(float rendimento){
            throw new NotImplementedException();
        }
    }
}