# ER3 

##  Validando Data de Nascimento

### Acessando a data do sistema - DateTime
 
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

### Fazendo contas com datas - TimeSpan

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




- _**var.**_ - tipo da variável, o tipo DateTime tem acesso a métodos relativos a data podendo acessar a data do sistema.













































