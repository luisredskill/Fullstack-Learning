# ER2 

##  Criação de Classes e instalação do .NET (C#)

### Sintaxe
 
O SQL é uma linguagem case-insensitive. Isso significa que caracteres em caixa alta e em caixa baixa são tratados de modo diferente. Para consultar todos os dados com todas as colunas da tabela de livros, por exemplo, podemos fazer da seguinte forma:

SELECT * FROM Livros ou select * from Livros

O comando SQL SELECT é lido da mesma maneira que select. No entanto, é uma boa prática destacar o comando SQL em letras maiúsculas, assim como iniciar o nome dos elementos com maiúscula, assim:

SELECT * FROM Livros

De modo geral, os comandos SQL são basicamente a ação seguido do nome do elemento que sofre a ação. Você pode finalizar a linha de comando com um ponto e vírgula e colocar o elemento entre colchetes, mas ambos são opcionais. Então:

SELECT * FROM Livros é lido da mesma maneira que SELECT * FROM [Livros];

Em alguns comandos, como o CREATE, precisamos abrir parênteses para passar os parâmetros. Dentro dos parênteses, usamos vírgula para separar os elementos. Uma boa prática é colocar a vírgula no início da linha, para melhor leitura. Vejam os exemplos a seguir, ambos corretos:

Vírgula entre os elementos, no final da linha

create table nome_tabela (
coluna_a tipo,
coluna_b tipo,
coluna_c tipo
)

Vírgula entre os elementos, no início da linha

create table nome_tabela (
coluna_a tipo
,coluna_b tipo
,coluna_c tipo
)

----------------------------------------------------------------------

### Linguagem de definição de dados - **DDL**

Fornece um conjunto de comandos para criar tabelas, chaves, alterar e apagar estruturas de tabelas (create, alter, drop).

----------------------------------------------------------------------

### Linguagem de manipulação de dados - **DDL**
 
Fornece um conjunto de comandos para realizar as manipulações dos dados armazenados (insert, update, delete).

----------------------------------------------------------------------

### Linguagem de consulta de dados - **DQL**

Fornece comandos para realizar consultas (select).

----------------------------------------------------------------------

### Linguagem de Transação de Dados - **DTL**

Comandos para controle de transação, como BEGIN TRANSACTION, COMMIT e ROLLBACK.

----------------------------------------------------------------------

### Linguagem de Controle de Dados - **DTL**

 Comando para controle e segurança de dados, como GRANT, REVOKE, DENY.

----------------------------------------------------------------------

### Comandos

 **_IDENTITY_** - indica que esse atributo será preenchido automaticamente e nunca irá se repetir, ideal para o primary key. Exemplo:  

	UsuarioId INT PRIMARY KEY IDENTITY

**_PRIMARY KEY_** - indica qual atributo vai ser a chave primária.

 **_UNIQUE_** - não permite que seja cadastrado duas informações iguais na mesma tabela, não permite que seja cadastrado dois e-mail iguais. Exemplo:

 Email VARCHAR(100) UNIQUE  

 **_NOT NULL_** - não permite que a informação fique vazia.

 **_INSERT INTO_** - indica a tabela que será inserido o conteúdo ao mesmo tempo que indica que algum atributo será inserido a ela. Exemplo:  

 ```

 INSERT INTO TabelaA VALUES('Fernando')

 ```

  **_INNER JOIN_** - Faz uma intersecção entre duas tabelas trazendo só o conteúdo que é igual em ambas. Exemplo: 

```
  SELECT TabelaA.Nome, TabelaB.Nome  FROM TabelaA INNER JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome
```
Neste caso, seria mostrado apenas os nomes que são idênticas na tabela A e na tabela B.

**_LEFT/RIGHT JOIN_** - Faz uma intersecção entre duas tabelas trazendo o conteúdo que é igual em ambas e todo o conteúdo da tabela a esquerda ou a direita. Exemplo: 

```
  SELECT TabelaA.Nome, TabelaB.Nome  FROM TabelaA LEFT JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome
```
Neste caso, seria mostrado os nomes que são idênticas na tabela A e na tabela B, além de toda a tabela A.

**_FULL OUTER JOIN_** - Faz uma intersecção entre duas tabelas trazendo TODO o conteúdo de AMBAS. Exemplo:
```
  SELECT TabelaA.Nome, TabelaB.Nome  FROM TabelaA FULL OUTER JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome
```
Neste caso, seria mostrado todo o conteúdo de ambas em uma única tabela.


----------------------------------------------------------------------


























