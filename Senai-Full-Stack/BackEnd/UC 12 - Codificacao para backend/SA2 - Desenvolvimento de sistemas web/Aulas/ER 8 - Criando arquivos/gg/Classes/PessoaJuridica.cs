using System.Text.RegularExpressions;
using Cadastro_Pessoa.Interfaces;

namespace Cadastro_Pessoa.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }


        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";



        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return 0;
            }
            else if (rendimento > 3000 && rendimento <= 6000)
            {
                return rendimento * 0.03f;
            }
            else if (rendimento > 6000 && rendimento < 10000)
            {
                return rendimento * 0.05f;
            }
            else
            {
                return rendimento * 0.9f;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))//função regular 
                                                                                     // \d{} - este comando verifica o numero de caracteres
                                                                                     // dentro do Regex é feito a combinação pelo operador | ou
            {
                if (cnpj.Length == 18) // se o tamanho do cnpj for 18 quer dizer que ele veio no formato 00.000.000/0001-00
                {
                    if (cnpj.Substring(11, 4) == "0001") // o Substring é um método que permite pegar apenas uma parte da string e verificá-la, neste caso os números que o argumento recebe representam,respectivamente, o ponto inicial da string e a quantidade de caracteres a partir do ponto inicial que formarão a string.
                    {
                        return true;
                    }
                }
                else
                { // todos os outros casos terao 14 digitos e virao no formato 00000000000100 
                    if (cnpj.Substring(8, 4) == "0001")
                    {
                        return true;


                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        public void Inserir(PessoaJuridica pj)
        {
            string[] pjString = { $"{pj.nome},{pj.cnpj},{pj.razaoSocial}" };

            VerificarPastaArquivo(caminho);

            File.AppendAllLines(caminho, pjString);
        }

        public List<PessoaJuridica> Ler()
        {
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");
                
                PessoaJuridica cadaPj = new PessoaJuridica();
                
                cadaPj.nome = atributos[0];

                cadaPj.cnpj = atributos[1];

                cadaPj.razaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }
            return listaPj;
        }
    }
}