# ER2 

##  Criação de Classes e instalação do .NET (C#)

### .NET
 
É uma ferramenta open-source de desenvolvimento para construção de aplicações. Necessária para programar em C#.

- _**instalação**_ - https://dotnet.microsoft.com/en-us/download

- _**sdk**_ - Utilizado para desenvolver

- _**runtime**_ - Executa aplicações desenvolvidas em .NET

----------------------------------------------------------------------

### Visual Studio Code (C# extensions)

- _**C#**_ - Microsoft
- _**C# Extensions**_ - jchannon
- _**C# Snippets**_ - Jorge Serrano
- _**C# XML Documentation Comments**_ - Keisuke Kato
- _**Rainbow Brackets**_ - 2gua

----------------------------------------------------------------------

### Comandos .NET
 
- _**dotnet new**_ - Da opções para criação de um projeto.

- _**dotnet new console**_ - Cria um novo projeto de console(padrão das aulas).

- _**dotnet run**_ - roda o código C#.

----------------------------------------------------------------------

### Criação de Classes e Interfaces 

- _**Botão direito na pasta ou diretório**_ ➝ _**New C# Class/Interface**_ 

----------------------------------------------------------------------

### Criação de Métodos

A criação de métodos é feita na seguinte ordem:  

- _**tipo de retorno**_  _**nomeDaFuncao(tipoDeInput nomeDoInput)**_  

Exemplo de função:

float PagarImposto(float rendimento)

Esta função **retorna** um float, tem como **nome** PagarImposto e utiliza como **argumento** um tipo float.  

----------------------------------------------------------------------

### Herança

A herança entre classes ou de interfaces para classes é feita na frente da classe, exemplo:

using _**suaPasta.Interfaces**_;

namespace _**suaPasta.Classes**_  
{    
	public class suaClasse : _**suaInterface/suaClasse**_    
	{  
    
   }  
}  

Note que se o arquivo estiver em outra pasta que não seja a raiz é necessário o uso do **using** para indicar a pasta em que a classe **herdada**.  

Quando herdamos **CLASSES** e **INTERFACES** ao mesmo tempo, a ordem é primeiro herdar das **classes** e, só depois, herdar das interfaces.

----------------------------------------------------------------------

### Criação de atributos

A criação de atributos é feita dentro de uma **classe** de forma a identificar, em ordem, o **modificador de acesso**, o tipo da **variável** e o **nome**. Exemplo:    

public string ?nome { get; set; }  

Note que se a variável começar vazia é necessário declarar que ela pode ser vazia com um ?.  

**Atalho** do **C# Snippets** > prop, prop faz toda a estrutura de atributo sozinho.

----------------------------------------------------------------------

### Abstração ou Superclasse

A abstração é feita **entre** o **modificador de acesso** e o nome **class**. Exemplo:  

public class Pessoa : IPessoa  

se torna:  

public **abstract** class Pessoa : IPessoa  

Isto torna **impossível** instanciar a classe pessoa!!!

----------------------------------------------------------------------

### Instanciando classes

O instanciamento é feito a partir da seguinte forma:  

Tipo nome = new tipo();  

Exemplo:  

PessoaFisica novaPf = new PessoaFisica();






































