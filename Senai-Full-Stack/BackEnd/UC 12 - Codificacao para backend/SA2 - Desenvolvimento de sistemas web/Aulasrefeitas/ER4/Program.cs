using ER2.Classes;

//PessoaFisica novaPf = new PessoaFisica();

//novaPf.nome = "Luis";
//string nome = novaPf.nome;
//Console.Clear();
//Console.WriteLine($"Nome: {nome}");

//novaPf.ValidarDataNascimento(new DateTime(1999,12,23));

PessoaJuridica metodoPj = new PessoaJuridica();

Console.WriteLine($"{((ER2.Interfaces.IPessoaJuridica)metodoPj).validarCnpj("00.000.000/0001-00")}");
