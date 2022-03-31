using ER2.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Luis";
string nome = novaPf.nome;
Console.Clear();
Console.WriteLine($"Nome: {nome}");

novaPf.ValidarDataNascimento(new DateTime(1999,12,23));




