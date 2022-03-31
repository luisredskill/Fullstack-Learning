# ER3 -Validando Data de Nascimento

## Acessando a data do sistema - Tipo DateTime
 
Acessar a data do sistema se da pela criação de uma variável que irá armazenar o dia atual.

- _**DateTime**_ - tipo da variável que armazena uma **data**, o tipo DateTime tem acesso a métodos relativos a data podendo acessar a data do sistema.

- _**DateTime.Now**_ - método que recebe data e hora do sistema.

- _**DateTime.Today**_ - método que recebe apenas a data.  

Exemplo: 

```
  public void ValidarDataNascimento()  
        {  
            DateTime dataAtual = DateTime.Today;  
            Console.WriteLine($"{dataAtual}");          
        }  
```

Este método acima, salvaria a data de **HOJE** em uma variável e, depois, mostraria ela no console.

----------------------------------------------------------------------

## Fazendo contas com datas - Tipo TimeSpan

### Como o TimeSpan trabalha?

É possível fazer contas com variáveis do tipo **DateTime**, onde duas **datas** serão subtraídas, o resultado desta conta é um tipo **TimeSpan** que armazena um período de tempo. Exemplo: 

```
   public void ValidarDataNascimento(new DateTime(1999,12,23))
        {
            DateTime dataAtual = DateTime.Today; // armazena a data atual
            TimeSpan resultado = (dataAtual - dataNasc);
          	
          	Console.WriteLine($"{resultado}");
    	}

    	// Retorno esperado do console, exemplo ficticio.
    	// 8134.10:36:37:856452
    	//Dias.Horas.Minutos.Segundos.milisegundos
```

Neste caso, o retorno no console se daria no formato que representa um **intervalo de tempo**.  

### Métodos do tipo TimeSpan 

Explicado o que é _**TimeSpan**_, temos alguns métodos que podem ser usados a partir de um _**intervalo de tempo**_. Exemplo:  


- _**.Add**_ - Adiciona outro _**intervalo de tempo**_ resultando em um tipo TimeSpan.

- _**.Days**_ - Retorna o número de dias, não converte horas em dias. O retorno é dado por um inteiro.

- _**.Hours**_ - Retorna o número de horas, não converte dias em horas. O retorno é dado por um inteiro. Inteiro.

- _**.TotalDays**_ - Retorna o número de dias totais, convertendo todos as horas, minutos,segundos,etc. O retorno é dado por um tipo double.  

Exemplos:  

```
   public void ValidarDataNascimento(new DateTime(1999,12,23))
        {
            DateTime dataAtual = DateTime.Today; // armazena a data atual

            int Days = (dataAtual - dataNasc).Days; //retorna o número de dias
            int Hours = (dataAtual - dataNasc).Hours;// retorna o número de horas
          	
          	Console.WriteLine($"Número de Dias: {Days}");
          	Console.WriteLine($"Número de Horas: {Hours}");
    	}

    	// Retorno esperado do console, exemplo ficticio.
    	// Número de dias: 8134
    	// Número de Horas: 11
```

Note que no exemplo de _**Hours**_ o número de horas subtraído. Ou seja, se o primeiro TimeSpan possuir um número de horas igual a 13 e o segundo 2, o resultado será a subtração de 13 por 2, 11. Não convertendo os dias em horas.  

```
   public void ValidarDataNascimento(new DateTime(1999,12,23))
        {
            DateTime dataAtual = DateTime.Today; // armazena a data atual

            double TotalDays = (dataAtual - dataNasc).TotalDays;
            double TotalHours = (dataAtual - dataNasc).TotalHours;
          	
          	Console.WriteLine($"Número de Dias: {TotalDays}");
            Console.WriteLine($"Número de Horas: {TotalHours}");
    	}

    	// Retorno esperado do console, exemplo ficticio.
    	// Número de dias: 8134,474538947633 
    	// Número de Horas: 195227,388933474318
```

Note que neste exemplo, _**diferente**_ do outro, todas as outras medidas são convertidas, resultando em um número _**TOTAL**_ de horas igual a _**195.227**_ horas.








































