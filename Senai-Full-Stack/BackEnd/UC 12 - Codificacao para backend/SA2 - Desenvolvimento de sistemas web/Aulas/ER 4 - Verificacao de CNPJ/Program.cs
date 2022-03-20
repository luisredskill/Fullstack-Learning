// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaFisica metodoPf = new PessoaFisica();
Endereco novoEnd = new Endereco();



//Console.WriteLine("Nome: " + novaPf.nome); // concatenacao
//Console.WriteLine($"Nome: {novaPf.nome}"); // interpolacao

//novaPf.nome = "Luis";
//novaPf.dataNascimento = "23/12/1999";
//novaPf.cpf = "123456790";
//novaPf.rendimento = 15000.5f; // f converte o tipo de retorno para float (8 casas decimais)
//novoEnd.Logradouro = "Dom Macario";
//novoEnd.Numero = 1071;
//novoEnd.Complemento = "Cursino,2000";
//novoEnd.endComercial = true;

//novaPf.endereco = novoEnd;

//Int16 dataValida = metodoPf.ValidarDataNascimento(novaPf.dataNascimento);

//Console.WriteLine($"Nome:  {novaPf.nome}");
//Console.WriteLine($"Endereco : {novaPf.endereco.Logradouro}, {novaPf.endereco.Numero}" );

//Console.WriteLine(@$"
//Nome:  {novaPf.nome}
//Endereco : {novaPf.endereco.Logradouro}, {novaPf.endereco.Numero}
//Maior de idade : {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
//");

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

Console.WriteLine(@$"
Nome:{novaPj.nome}
RazaoSocial:{novaPj.razaoSocial}
CNPJ:{novaPj.cnpj}
CNPJ Valido:{metodoPj.ValidarCnpj(novaPj.cnpj)}");

