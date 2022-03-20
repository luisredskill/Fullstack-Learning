// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa.Classes;

Console.WriteLine(@$"
===========================================================
|           Bem-vindo ao sistema de cadastro de           |
|              Pessoas Fisicas e Juridicas                |
===========================================================");

BarraCarregamento("Carregamento", 500);

string? opcao;

do
{

    Console.Clear();

    Console.WriteLine(@$"
===========================================================
|              Escolha uma das opções abaixo              |
|---------------------------------------------------------|
|                   1 - Pessoa Física                     |
|                   2 - Pessoa Jurídica                   |
|                                                         |
|                   0 - Sair                              |
===========================================================
");
    List<PessoaFisica> listaPf = new List<PessoaFisica>();
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            PessoaFisica metodoPf = new PessoaFisica();


            string opcaoPf;
            do
            {
                Console.Clear();

                Console.WriteLine(@$"
===========================================================
|              Escolha uma das opções abaixo              |
|---------------------------------------------------------|
|                   1 - Cadastrar Pessoa Física           |
|                   2 - Mostrar Pessoa Física             |
|                                                         |
|                   0 - Voltar ao menu anterior           |
===========================================================
");

                opcaoPf = Console.ReadLine();
                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa fisica que deseja cadastrar");

                        novaPf.nome = Console.ReadLine();

                        bool dataValidada;

                        do
                        {

                            Console.WriteLine($"Digite a data de nascimento EX:DD/MM/AAAA");
                            string dataNasc = Console.ReadLine();

                            dataValidada = metodoPf.ValidarDataNascimento(dataNasc);
                            if (dataValidada)
                            {
                                novaPf.dataNascimento = dataNasc;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data invalida, por favor digite novamente uma data no formato DD/MM/AAAA");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                            }
                        } while (dataValidada == false);

                        Console.WriteLine($"Digite o numero do CPF");
                        novaPf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal(digite somento numeros)");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEnd.Logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero");
                        novoEnd.Numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento, aperte enter para vazio");
                        novoEnd.Complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEnd.endComercial = true;
                        }
                        else
                        {
                            novoEnd.endComercial = false;
                        }



                        novaPf.endereco = novoEnd;
                        listaPf.Add(novaPf);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"cadastro realizado com sucesso =>");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                    case "2":
                        Console.Clear();
                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
             Nome:  {cadaPessoa.nome}
             Endereco : {cadaPessoa.endereco.Logradouro}, {cadaPessoa.endereco.Numero}
             Data de Nascimento : {cadaPessoa.dataNascimento} 
             Taxa de imposto a ser paga: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")} 
             ");
             Thread.Sleep(3000);

                            }
                        }
                        else
                        {
                            Console.WriteLine($"ListaVazia!!");
                            Thread.Sleep(3000);
                      }


                        break;
                    case "0":

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(@$"
    Opção inválida, por favor digite outra opção...");
                        Thread.Sleep(2500);
                        break;
                }

            } while (opcaoPf != "0");










            break;

        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Lucabari";
            novaPj.cnpj = "45.454.103/0001-60";
            novaPj.razaoSocial = "Lucabari";
            novaPj.rendimento = 20000.5f;

            novoEndPj.Numero = 1071;
            novoEndPj.Logradouro = "Dom macario";
            novoEndPj.endComercial = true;
            novoEndPj.Complemento = "Cursino 2000";

            novaPj.endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"
Nome:{novaPj.nome}
RazaoSocial:{novaPj.razaoSocial}
CNPJ:{novaPj.cnpj}
CNPJ Valido:{metodoPj.ValidarCnpj(novaPj.cnpj)}");


            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

            break;

        case "0":
            BarraCarregamento("Finalizando", 250);
            break;

        default:
            Console.Clear();
            Console.WriteLine(@$"
    Opção inválida, por favor digite outra opção...");
            Thread.Sleep(2500);
            break;
    }
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{

    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;

    Console.Write($"{texto}");

    for (var contador = 0; contador < 10; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(250);
    }
    Console.ResetColor();
}





