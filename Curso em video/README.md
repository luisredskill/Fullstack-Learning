# Conteúdo de suporte de comandos Curso em Video
------------------------------------------------------------------------------

## Comandos 

- **_window.alert_** - Mostra uma mensagem ao usuário

- **_window.confirm_** - pergunta algo ao usuário gerando uma resposta true or false

- **_window.prompt_** - abre um espaço para o usuário digitar uma informação que sempre será guardada em formato de sting.

- **_document.writeIn()_** - Escreve na página o conteúdo digitado entre parenteses.

 - **_document.write()_** - Busca conteúdo de texto armazenada em variáveis
Exemplo:  

var nome = window.prompt("Qual e o seu nome?")
       window.alert('É um grande prazer te conhecer '+nome)    

- **_array vazio_** - para criar um array vazio utilizado para inserção de variáveis é utilizado a seguinte forma  

var nomes = []

- **_inserir elementos em um array_** - comando utilizado:  

nome.push(nomes)





 

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Comandos de Utilidade


- **_Number.parseInt_** , **_Number.parseFloat_** e **_Number_**- transforma o tipo de dado em número **INTEIRO** e **REAL**, respectivamente. 

var n1 = Number.parseInt(window.prompt('digite um numero'))   
var n2 = Number.parseFloat(window.prompt('digite o código de segurança')) 
var n3 = Number(numero) - numero neste caso é uma variável string que será convertida.  


- **_toUpperCase()_** e **_toLowerCase()_** - Transforma uma cadeia de caracteres em todos maiusculos ou todos minusculos, respectivamente.

 document.writeln(`Seu nome em minusculas é ${nome.toLowerCase()}`)
 document.writeln(`Seu nome em maiuculas é ${nome.toUpperCase()}.`)  

- **_Place Holder_** - placeholder é uma forma mais simples de concatenar consiste em declarar o placeholder com o simbolo "$" e depois declarar a variavel ou função entre colchetes, para isso é necessário usar crase. Exemplo:

var n1 = 2  
var n2 = 5  
var s = n1+n2  

window.alert("A soma entre ${n1} e ${n2} é igual a ${s}."), o resultado disso sera:

A soma entre 2 e 5 é igual a 7.

- **_toFixed()_** e **_toFixed().replace()_**  - fixa o número de casas decimais de um número e troca algum dos termos que aparecerão por outro. Exemplo 1:  

n1 = 10.5  
n1.toFixed(2)
n1 = 10.50  

Exemplo 2:  

n1 = 10.5  
n1.toFixed(2).replace(".",",") - trocar ponto por vírgula
n1 = 10,50  

**_Converter Moeda para Real_**  

n1.toLocaleSting("pt-BR", {style: "currency", currency: "BRL"})

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Comandos de Busca (1/2)

- **_1 - getElementsByTagName(ache os elementos por tag)_** - Este buscador busca elementos do texto pela tag, por exemplo, buscar um paragrafo (tag p):

<.p> Primeiro paragrafo, **negrito** <./p>  
var A = window.document.getElementsByTagName("p")[0]  

Agora o conteúdo da variável A é o primeiro parágrafo.  

- **_IMPORTANTE:.innerText_** e **_.innerHTML_** - o primeiro busca apenas o texto dentro de um arquivo, enquanto o segundo busca o texto e a formatação presente no HTML. Exemplo:

document.write(A.innerText) > Primeiro paragrafo, negrito     

document.write(A.innerHTML) Primeiro paragrafo, **negrito**   

- **_2 - getElementById (ache O elemento por ID)_** - busca UM elemento que tem o ID especifico. Exemplo:

var d = window.document.getElementById("msg")

- **_3 - getElementByName (ache O elemento por nome)_** - busca TODOS os elementos que tem o NOME especifico e apresenta um deles. Exemplo:

var d = window.document.getElementByName("msg")[0]

- **_3 - querySelector() ou querySelectorAll()_** - seleciona um arquivo de forma a constar nos argumentos a TAG e outro identificador. Exemplo:

var d = window.document.querySelector("div#msg")  

Note que div é uma tag e msg é o ID dado a frase.

**IMPORTANTE** - durante o uso do querySelector, deve-se notar que toda div é representada por "#", toda classe é representada por ".".

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Identificadores para busca (2/2)

- **_1 - Tag_** - identifica partes do texto por uma marcação, como o começo e o final de um parágrado do texto, da parte de javascript, CSS ou até mesmo se uma palavra está em negrito ou não. Ignore os pontos.

<.p></.p> - <.script></.script> - <.style></.style> - <.body></.body>

- **_2 - ID_** - identifica partes do seu documento com um identificador, facilitando a organização e a busca futura dessa informações, so pode ser usado um ID com o mesmo nome por vez, isto e, so pode ser utilizado uma vez por ID. Ignore os pontos.

<.div id = "msg"></.div>

todo vez que for buscado o ID msg, o resultado será o conteúdo dessa div.

- **_2 - NAME_** - identifica partes do seu documento com um nome, possibilitando a busca de todos os elementos com este nome. Ignore os pontos.

<.div name = "msg"></.div>

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Comandos de eventos  

- **_addEventListener_** - adiciona um ouvidor que sempre estara atento ao evento. Exemplo:   

objeto_a_ser_monitorado.addEventListener("nome_do_evento", nome_da_funcao)
a.addEventListener("click", clicar)

Neste exemplo, o ouvidor ira trabalhar dentro do objeto a, toda vez que o mouse clicar dentro da area do objeto a, ele ira executar a funcao clicar.


- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## HTML - input  

- **_input_** - adiciona um tipo de caixa de interacao com o usuario que permite a ele colocar informacoes como datas, numeros, documentos, textos, e interagir de diversas formas.  

<input type="number" name ="n1" id="n1">  
<input type="button" value="Somar" onclick="somar()">

var a = document.getElementById ("txtn1")

no primeiro exemplo, temos uma area para a digitacao de um numero que sera salvo pela variavel a

no segundo exemplo, temos uma area criada para um botao que pode interagir com o usuario de forma a fazer algo, no caso executa uma funcao que tem o nome de somar e sera executada ao clicar em cima da area do botao.

## Javascript - input

- **_input_** - para armazenar um input em uma variável devemos usar a seguinte estrutura:

<input type="text" name ="txtn1" id="txtn1"> 
var nome = document.getElementById("txtn1") - Este tipo de var retorna HTML element
var nome1 = nome.value - Este tipo de var retorna o valor do elemento, no caso, o nome.





- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Edição de Texto

- **_font_** - edita a fonte da pagina na parte de css, exemplo:  

font: normal 20pt Arial;  

- **_background_** - edita a cor da pagina ou area selecionada na parte de css, exemplo:  

 background: green;

- **_color_** - Edita a cor do elemento (letra no exemplo)  

 color:white;

- **_width e  height_** - Define a largura do objeto selecionado ou da pagina. Exemplo:  
 
 width: 200px;
 height: 200px;

 - **_line-height e  text-align_** - Define a altura da linha em que o texto esta e define o tipo de alinhamento que sera aplicado no texto. Exemplo:  

  line-height: 200px;
  text-align: center;

## Eventos uteis   
https://developer.mozilla.org/pt-BR/docs/Web/Events - referencia de eventos da mozila, caso nao ache um evento provavelmente ele estara aqui
### Eventos de mouse   

- **_mouseenter_** - Aciona algo quando o mouse entra em um area  
- **_mousemove_** - Aciona algo quando o mouse se move em um area  
- **_mouseup_** - Aciona algo quando o mouse sobe em um area
- **_mousedown_** - Aciona algo quando o mouse e pressionado para baixo com o botao esquerdo dentro de uma area  
- **_click_** - Aciona algo quando o mouse clica em uma area  
- **_mouseout_** - Aciona algo quando o mouse sai de uma area  




















