namespace POO.classes
{
    public class Caneta
    {
        private String modelo { get; set; }
        private float ponta { get; set; }
        private bool tampada { get; set; }
        private string cor { get; set; }





        public Caneta(String m, String c, float p)
        {
            this.setModelo(m);
            this.tampar();
            this.setCor(c);
            this.setPonta(p);
        }

        public String getModelo()
        {
            return this.modelo;
        }
        public void setModelo(String m)
        {
            this.modelo = m;
        }
        public float getPonta()
        {
            return this.ponta;
        }
        public void setPonta(float p)
        {
            this.ponta = p;
        }

        public bool getTampada()
        {
            return this.tampada;
        }

        public void setTampada(bool b)
        {
            this.tampada = b;
        }

        public string getCor()
        {
            return this.cor;
        }

        public void setCor(string c)
        {
            this.cor = c;
        }

        public void tampar()
        {
            this.tampada = true;
        }



        public void destampar()
        {
            this.tampada = false;
        }

        public void status()
        {
            Console.WriteLine($"Sobre a caneta");
            Console.WriteLine($"Modelo: {this.getModelo()}");
            Console.WriteLine($"Ponta: {this.getPonta()}");
            Console.WriteLine($"Cor: {this.cor}");



        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}