using Ex01_2.Classes;

Pessoa pess = new Pessoa();
Pessoa metodo = new Pessoa();

static void Carregar(string texto, int tempo){
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write(texto);
    for (var contador = 0; contador < 7; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}

Console.WriteLine(@$"
===========================================================
|   Bem-vindo ao sistema de tudo que eu conseguir fazer   |
===========================================================");


Carregar("Iniciando", 500);

Console.WriteLine(@$"
===========================================================
|              Escolha uma das opções abaixo              |
|---------------------------------------------------------|
|                   1 - Cadastro de pessoas               |
|                   2 - Informações de pessoas            |
|                                                         |
|                   0 - Sair                              |
===========================================================
");






//metodo.ContarLetras("gg");
