using Ex01.Classes;

Pessoa metodoPf = new Pessoa();

Console.WriteLine($"Bem-vindo ao sistema de checagem de maioridade para votacao");
 Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
Console.WriteLine($"Digite a sua data de nascimento no formato 00/00/0000");
string? dataRecebida;
dataRecebida = Console.ReadLine();
Console.WriteLine($"{metodoPf.lerData(dataRecebida)}");

switch (metodoPf.lerData(dataRecebida))
{
    case 1:
    Console.WriteLine($"Usuário maior de 18 anos, voto obrigatório");
    
        break;
         case 2:
    Console.WriteLine($"Usuário maior de 16 anos, voto opcional");
    
        break;
         case 3:
    Console.WriteLine($"Usuário menor de 16 anos, SEM direito ao voto");
    
        break;
         case 4:
    Console.WriteLine($"formato data inválida");
    
        break;
    default:
        break;
}


 




//metodoPf.lerData();











