using Cadastro_Pessoa.Interfaces;

namespace Cadastro_Pessoa.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?nome {get;set;}

        public Endereco ?endereco { get; set; }   

        public float rendimento { get; set; }
        
        
        
        


        public abstract float PagarImposto(float rendimento);
      

        public void VerificarPastaArquivo(string caminho){
            string pasta = caminho.Split("/")[0]; // .Slit divide uma string dando um elemento como elemento divisor, neste caso "/"

            if (!Directory.Exists(pasta)) // verifica se o diretorio existe
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(caminho)) // verifica se o caminho existe
            {
                File.Create(caminho);
                
            }
        }
    }
}