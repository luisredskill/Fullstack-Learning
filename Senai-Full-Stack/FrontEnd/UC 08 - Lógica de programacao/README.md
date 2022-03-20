# Conteúdo de suporte de comandos UC08 - Lógica de Programação
-------------------------------------------------------------------------------

## Variáveis

- **_var número = 10_** - declara uma variável que receberá um tipo de dano, podendo ser um número ou um nome e receber novos dados que substituem essa variável.

- **_let nome = João_** - declara uma variável que receberá um tipo de dano, podendo ser um número ou um nome e receber novos dados que substituem essa variável.

- **_Const Pi = 3,14_** - declara uma constante que receberá um tipo de dano, não podendo ser alterada.

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Operadores Lógicos

- **_Exemplificacao do operador AND (E) simbolo &&_** - O operador AND true retornará se ambos os operands são true e retornarão caso false contrário.  

true && true > true  
true && false > false  
false && true > false  
false && false > false  



**_Exemplificacao do operador OR (OU), simbolo ||_** - O operador OR true retornará se qualquer um dos operands ou ambos for true e retornarão caso false contrário.  

true || true > true  
true || false > true  
false || true > true  
false || false > false  

**_Exemplificacao do operador NOT (NÃO), simbolo !_** - Inverte o resultado. O resultado será true se o operand convertido for false ; o resultado será se o false operand convertido for true . O resultado é do tipo bool .

!true > false  
!false > true  

**IMPORTANTE!**, existe uma ordem de precedencia, onde se e resolvido em uma ordem especifica os operadores logicos, esta ordem é !,&& e ||.

**_Exemplificacao do operador %(resto da divisão)_** - Faz uma divisão entre dois números e o resultado é o resto da divisão. Exemplo:

5%2 = 1
6%2 = 0

**_Exemplificacao do operador **(potencia)_** - faz um numero elevado ao outro. Exemplo:

 5**2 = 25
 3**2 = 9

**_Exemplificacao do operador ==(igual) e !=(diferente)_** - mostra igualdade entre duas grandezas ou mostra que duas grandezas sao diferentes, respectivamente.Exemplo:

5==5 = true 
5==2 = false
5!=6 = true
5!=5 = false

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Comandos de decisão

- **_Condição SE(IF), faz algo se a condição for cumprida.Exemplo:_**

if(condition){  
	what happens if the condition is true  
}  
if(numero == 10){    
	console.log("O numero contido na variavel numero **é** 10")    
}  


- **_Condição IF ELSE(SE NÃO), é utilizado sempre junto com um if anterior, onde esta condição é verificada apenas quando o resultado do if anterior tem um resultado FALSE,_** 

"**SE** a condição antiror **NÃO** for atendida".**_Exemplo:_**

else if(condition){  
	what happens if the condition is true  
}  
else if(numero < 10){    
	console.log("O número contido na variavel numero é **menor** que 10")    
}  


- **_Condição ELSE(OUTRO), é utilizado sempre junto com um if anterior E/OU else if, onde é executado apenas quando todos os if e/ou else if dão um resultado FALSE,_** 

"se todas as **OUTRAS** condições anteriores **NÃO** forem atendidas".**_Exemplo:_**

else{  
	what happens if all the conditions resulted in false  
}  
else{   
	console.log("O número contido na variavel numero é **maior** que 10")    
}  

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Estruturas de repetição

- **_While(Enquanto)_** - Este comando verifica a condição e, caso ela seja verdadeira ele executa o comando, repetindo o processo até que a condição seja falsa.Exemplo:

let listaDeAlunos = ["Marcelo","Juh", "Cleber", "Wesley","Adriano"]  
let contador = 0  
while(contador < listaDeAlunos.lenght){  
	console.log(listaDeAlunos[contador])  
	contador++  
}

- **_DO While(Faça Enquanto)_** - Este comando executa antes de verificar a condição pelo menos uma vez e, caso ela seja verdadeira, continua a executar o comando até ela se tornar falsa.Exemplo:

let listaDeAlunos = ["Marcelo","Juh", "Cleber", "Wesley","Adriano"]  
let contador = 0  
do{  
	console.log(listaDeAlunos[contador])  
	contador++  
}  
while  (contador < listaDeAlunos.length) 

- **_FOR(PARA)_** - O comando for permite que um certo trecho de programa seja executado um determinado número de vezes. No exemplo abaixo o comando for faz a contagem dos numeros informando se são pares ou impares.

let numeroDeAlunos = 10;  

for (let contador = 0; contador <= numeroDeAlunos; contador++) {  
   if (contador === 0) {    
       console.log("O número atual é Zero")    
       } else if (contador%2 == 0) {     
        console.log("O número " + contador +" é Par")    
       } else {  
           console.log("O número " + contador +" é Ímpar")    
    }  
}  

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Mais estruturas de repetição

- **_FOR OF(PARA DE)_** - Percorre objetos iterativos (incluindo Array, Map, Set, o objeto arguments e assim por diante), chamando uma função personalizada com instruções a serem executadas para o valor de cada objeto distinto.

let listaDeAlunos = ["Marcelo","Juh", "Cleber", "Wesley","Adriano"]  
for (const aluno of listaDeAlunos){  
console.log(aluno)  
}

- **_FOR EACH(PARA CADA)_** - O método forEach() executa uma dada função em cada elemento de um array.

let listaDeAlunos = ["Marcelo","Juh", "Cleber", "Wesley","Adriano"]  
listaDeAlunos.forEach(aluno => {  
    console.log(aluno)  
});  

Dentro do argumento da estrutura de repetição podem ser usados ainda argumentos como funções, Exemplo:  

function listadepecas(element, index, array) {      
 lista.innerHTML += `<p>${element} [${index + 1}] ${pesos[index]} gramas</p>`  
 }    
 pecas.forEach(listadepecas)   
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Mais Comandos Aprendidos nesta unidade

- **DATE**_ - É um objeto do tipo DATE, que armazena uma série de funções dentro dele permitindo o acesso rápido a funções ligadas a hora, dia, mes e ano atuais. É muito útil em processos que dependem de tempo para serem feitos ou cadastrados.

**let** - Declara a váriavel que irá conter o objeto, sempre que chamarmos essa váriavel seguida de ".", estaremos chamando as funções dentro dele. Exemplo
**new** - Declara que existe um objeto dentro da variável, sem isto seria criado uma váriavel contendo a string "DATE"
**Date()** - Declara o objeto especifico com suas funcionalidades

Exemplo:

let a = **new** Date()  
a.GetMonth() - chama a função que dirá o mês atual  
a.getFullYear() - Ano  
a.getDate() - Dia  

Exemplo de sintaxe completa:

let dataAtual = new Date()  
let ano = 2021 - informacao digitada pelo usuario  

if (ano > dataAtual.getFullYear()){  
    console.log("Esta data é no ano que vem")   
}  

**style.display** - Recebe os valores "none" e "block", o none deixa o texto, elementos em questao invisiveis e o block os mostra de novo.  

<**div id="contextText"**><**p**>Texto que vai sumir<**/p**><**/div**>  
var x = document.getElementById('contextText');    
x.style.display ==='none' - deixa o texto invisivel  
x.style.display = 'block' - deixa o texto visivel

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Classes Jquery

    Um exemplo prático para o uso das classes ocorre quando você tem uma div pai que contém diversas tags p e você deseja estilizar apenas uma. Nessa situação, você pode adicionar uma class para essa tag específica e, no JavaScript, você irá chamá-la utilizando esse método e passando como condição a estilização.

**.addClass() E .removeClass()** - .addClass e .removeClass adicionam e removem, respectivamente, a class dos elementos do HTML, alterando seu estado, ou seja, sua estilização.  

$("p").addClass("#demo");     
$("p").removeClass("#demo").addClass(".textStyle");  

o **id** ou **class** é selecionado pelo simbolo de # ou ., para definir se será adicionado uma class ou um id.  

_**.hasClass()**_ - .hasClass é um método que retorna true ou false, pois ele irá comparar a class atribuída ao elemento do HTML.  

<**div id ="mydiv" class="foo bar"**><**/div**>
$("#mydiv").hasClass("foo")






