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

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodoPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();



            Console.WriteLine("Nome: " + novaPf.nome); // concatenacao
            Console.WriteLine($"Nome: {novaPf.nome}"); // interpolacao

            novaPf.nome = "Luis";
            novaPf.dataNascimento = "23/12/1999";
            novaPf.cpf = "123456790";
            novaPf.rendimento = 15000.5f; // f converte o tipo de retorno para float (8 casas decimais)
            novoEnd.Logradouro = "Dom Macario";
            novoEnd.Numero = 1071;
            novoEnd.Complemento = "Cursino,2000";
            novoEnd.endComercial = true;

            novaPf.endereco = novoEnd;

            bool dataValida = metodoPf.ValidarDataNascimento(novaPf.dataNascimento);

            //Console.WriteLine($"Nome:  {novaPf.nome}");
            //Console.WriteLine($"Endereco : {novaPf.endereco.Logradouro}, {novaPf.endereco.Numero}");
            Console.Clear();
            Console.WriteLine(@$"
Nome:  {novaPf.nome}
Endereco : {novaPf.endereco.Logradouro}, {novaPf.endereco.Numero}
Maior de idade : {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento) ?"Sim" : "Nao")} 
Taxa de imposto a ser paga e:{metodoPf.PagarImposto(novaPf.rendimento).ToString("C")} 
");// metodo .ToString transforma a saida em uma String, a letra C, representa o padrao de formato moeda.
// if ternario tem a estrutura que altera o retorno para true e para false, vem na forma ?"Sim": "Nao".
            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

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





