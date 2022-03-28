namespace POO.classes
{
    public class Caneta
    {
        public string? modelo;
        public string? cor;
        public float? ponta;
        public int? carga;
        public bool tampado;


        private void Tampar()
        {
            this.tampado = true;
        }
        public void rabiscar()
        {
            if (this.tampado == false)
            {
                Console.WriteLine($"rabisqueiiiiiiiiiiiiii");

            }
            else
            {
                Console.WriteLine($"num rabisqueiiiiiiiiii");

            }
        }
        private void destampar()
        {
            this.tampado = false;
        }
        public void status()
        {
            Console.WriteLine($"---------------------------------");

            Console.WriteLine($"Uma caneta{this.cor}");
            Console.WriteLine($"está tampada? {this.tampado}");
            Console.WriteLine($"Qual modelo? {this.modelo}");
            Console.WriteLine($"Qual tamanho da ponta? {this.ponta}");
            Console.WriteLine($"Quanto de carga lhe resta? {this.carga}");

        }
        public void pintar()
        {

        }
        public void escrever()
        {

        }
    }
}