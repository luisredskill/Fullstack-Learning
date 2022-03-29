namespace B.classes
{
    public class ContaBanco
    {
        public int numConta { get; set; }
        protected string tipo { get; set; }
        private string dono { get; set; }
        private float saldo { get; set; }
        private bool status { get; set; }

        // ------------------------------------------- Metodo Construtor

        public ContaBanco(int numConta, string tipo, string dono)
        {

            this.numConta = numConta;
            this.tipo = tipo;
            this.dono = dono;
            this.saldo = 0f;
            this.status = false;

            this.abrirConta();
        }

        // ----------------------------------------- GETTERS E SETTERS

        public int getNumConta()
        {
            return this.numConta;
        }
        public void setNumConta(int N)
        {
            this.numConta = N;
        }
        public string getTipo()
        {
            return this.tipo;
        }
        public void setTipo(string t)
        {
            this.tipo = t;
        }
        public string getDono()
        {
            return this.dono;
        }
        public void setDono(string d)
        {
            this.dono = d;
        }
        public float getSaldo()
        {
            return this.saldo;
        }
        public void setSaldo(float s)
        {
            this.saldo = s;
        }
        public bool getStatus()
        {
            return this.status;
        }
        public void setStatus(bool sta)
        {
            this.status = sta;
        }

        // ----------------------------------------- Metodos Modificadores

        public void Geral()
        {
            Console.WriteLine(@$"
            Número da conta: {this.getNumConta()}
            Tipo: {this.getTipo()}
            Dono: {this.getDono()}
            Saldo: {this.getSaldo()}
            Status: {this.getStatus()}
            ");
        }
        public void abrirConta()
        {
            if (this.getTipo() == "cc")
            {
                this.setSaldo(50);
            }
            else
            {
                this.setSaldo(150);
            }
            this.setStatus(true);

        }
        public void fecharConta()
        {
            if (this.getSaldo() == 0)
            {
                Console.WriteLine($"Impossivel fechar a conta, seu saldo não pode ser maior ou menor que 0. O saldo atual é de {this.getSaldo()}.");

            }
            if (this.getStatus() == false)
            {
                Console.WriteLine($"Impossivel fechar a conta, ela já está fechada.Status: {this.getStatus()}.");
            }
            else
            {
                this.setStatus(false);
                Console.WriteLine($"Conta fechada com sucesso. Status: {this.getStatus()}.");

            }
        }
        public void Depositar(float deposito)
        {
            if (this.getStatus())
            {
                this.setSaldo(this.getSaldo() + deposito);
                Console.WriteLine($"{this.getSaldo()}");
            }
            else
            {
                Console.WriteLine($"Impossível depositar, a conta está fechada.");

            }

        }

        public void Sacar(float saque)
        {
            if (this.getStatus())
            {
                this.setSaldo(this.getSaldo() - saque);
                Console.WriteLine($"{this.getSaldo()}");
            }
            else
            {
                Console.WriteLine($"Impossível sacar, a conta está fechada.");

            }

        }

        public void pagarMensalidade()
        {
            if (this.getTipo() == "cc" || this.getTipo() == "cp")
            {
                if (this.getStatus())
                {
                    if (this.getTipo() == "cc")
                    {
                        this.setSaldo(this.getSaldo() - 12);
                         Console.WriteLine($"Mensalidade paga para conta corrente, foram cobrados 12R$.");
                    }
                    else
                    {
                        this.setSaldo(this.getSaldo() - 20);
                         Console.WriteLine($"Mensalidade paga para conta corrente, foram cobrados 20R$.");
                    }

                } else
                {
                    Console.WriteLine($"Impossível pagar a mensalidade, a conta está fechada.");
                }


            } else
                {
                    Console.WriteLine($"Impossível pagar a mensalidade, tipo de conta invalido.");
                }

            Console.WriteLine($"Saldo restante: {this.getSaldo()}");

        }
    }
}