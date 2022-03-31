# ER3 

##  Validando Data de Nascimento

### Acessando a data do sistema
 
Acessar a data do sistema se da pela criação de uma variável que irá armazenar o dia atual.

- _**DateTime**_ - tipo da variável, o tipo DateTime tem acesso a métodos relativos a data podendo acessar a data do sistema.

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

----------------------------------------------------------------------







































