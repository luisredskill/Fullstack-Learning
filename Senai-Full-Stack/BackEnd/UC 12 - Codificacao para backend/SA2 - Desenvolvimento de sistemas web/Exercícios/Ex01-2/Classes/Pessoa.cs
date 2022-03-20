namespace Ex01_2.Classes
{
    public class Pessoa
    {
        public string? nome {get ; set;}
        public string? nasc {get; set;}

        public void ContarLetras(string nomeRecebido){
            float? contado = nomeRecebido.Length;
            Console.WriteLine(contado);
            
            
        }
    }
}