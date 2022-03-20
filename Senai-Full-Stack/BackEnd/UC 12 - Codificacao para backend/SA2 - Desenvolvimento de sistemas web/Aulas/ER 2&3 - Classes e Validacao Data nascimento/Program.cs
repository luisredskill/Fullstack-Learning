// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaFisica metodoPf = new PessoaFisica();
Endereco novoEnd = new Endereco();



//Console.WriteLine("Nome: " + novaPf.nome); // concatenacao
//Console.WriteLine($"Nome: {novaPf.nome}"); // interpolacao

novaPf.nome = "Luis";
novaPf.dataNascimento = "23/12/1999";
novaPf.cpf = "123456790";
novaPf.rendimento = 15000.5f; // f converte o tipo de retorno para float (8 casas decimais)
novoEnd.Logradouro = "Dom Macario";
novoEnd.Numero = 1071;
novoEnd.Complemento = "Cursino,2000";
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

//Int16 dataValida = metodoPf.ValidarDataNascimento(novaPf.dataNascimento);

//Console.WriteLine($"Nome:  {novaPf.nome}");
//Console.WriteLine($"Endereco : {novaPf.endereco.Logradouro}, {novaPf.endereco.Numero}" );

Console.WriteLine(@$"
Nome:  {novaPf.nome}
Endereco : {novaPf.endereco.Logradouro}, {novaPf.endereco.Numero}
Maior de idade : {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
");

