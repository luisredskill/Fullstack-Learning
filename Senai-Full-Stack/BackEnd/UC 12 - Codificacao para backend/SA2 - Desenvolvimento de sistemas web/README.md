# Conteúdo de suporte de comandos SA2 - Implementação de interface
-------------------------------------------------------------------------------

## C# 

### Comandos

    Tags são usadas para para representar conteúdos que estão dentro de um de um grupo de dados

- _**Criar**_ "dotnet new" ou "dotnet new console"

- _**Rodar>**_ - dotnet run
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Programação 

    Atributos são usados para definir características relevantes do documento HTML como altura e largura de elementos.

- _**lang**_ Esta parte do HTML indica a linguagem do documento.  
<**html lang="pt-br"**>  

- _**charset="utf-8"**_ Esta parte do HTML garante a compatibilidade com os layouts de teclado latino-amerinos, lendo corretamente a cedilha e acentuacoes.

- _**src**_ - Indica a origem de um arquivo de audio, video, imagem, etc.  

- _**class**_ - Aplicada para formatar vários elementos de uma vez.  
<**h1 class="titulo_post"**> 

- _**id**_ - É aplicada para formatar um único elemento. Não pode começar com número ou hífen.  
<**h2 id="destaque_header"**>  

- _**style**_ - Permite incluir estilos de CSS dentro da tag.  
<**table style="border: 1px solid black"**>  

- _**title**_ - Define o título do elemento.  
<**img src="img/bolo1.jpg" title="Bolo caseiro de chocolate"**>    

- _**alt**_ - Define um texto alternativo e, por isso, é muito utilizado para descrição de imagens.  
<**img src="img/bolo1.jpg" alt="A imagem mostra um bolo de chocolate sobre uma mesa de madeira."**>  

- _**hidden**_ - Oculta o elemento.  
<**p hidden>Trecho de texto em aprovação<**/p>  

- _**align**_ - Define o padrão de alinhamento, como: right (direita), center (centralizado), left (esquerda) e justify (justificado).  
<**h2 align="center">Título centralizado**<**/h2**>  

- _**width**_ - 	Determina a largura do elemento  
<**img src="img/bolo1.jpg" width="100%"**>  

- _**height**_ - 	Define uma altura para o elemento.  
<**img src="img/bolo1.jpg" height="300px"**>  
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Dentro da tag <**head**>

     Alguns atributos do arquivo HTML Tem que ser colocados dentro da tag HEAD, alguns deles são muito importantes como a "description" e "keywords", que fornece uma descrição do site e as palavras chaves usadas em mecanismos de busca.

- _**"description"**_ - Fornece uma breve descricao do site para mecanismos de busca de navegadores utilizarem.

<**meta** name="description" content="Codificacao Front-End, SENAI" />

- _**"keywords"**_ - O navegador le essas palavras e exibem o site como sugestao em resultados de pesquisa.

<**meta** name="keywords" content="HTML,CSS,Javascript, SENAI" />

- _**"author"**_ - Nome do(s) programador(es) do documento HTML.

<**meta** name="author" content="Luis Carlos" />

- _**"viewport"**_ - Esse metadado indica para o navegador a largura para renderização, que deve se adaptar de acordo com o dispositivo de acesso (responsividade).

<**meta** name="viewport" content="width=device-width, initial-scale=1.0">

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Elementos body

     Elementos e atributos que fazem parte do body.

- _**header**_ - É o cabeçalho do documento; geralmente agrupa um conjunto de links de navegação (menu) e os títulos.  

    <**header**>
    <!-- tag nav aqui -->
        <**h1**>Bem-vindo à página de exemplo<**/h1**>
        <**h2**>Complemente seus estudos<**/h2**>
    <**/header**>

- _**<**nav**>**_ - Reúne links para a navegação (menu principal); normalmente está incluída dentro do <**header**>. Exemplo:  

    <**nav id="menu"**>
        <**a href="index.html">home<**/a**>
        <**a href="interna01.html">interna01<**/a**>
        <**a href="interna02.html">interna02<**/a**>
    <**/nav>  

- _**<**nav**>**_ - É utilizada para fins de estilo; pode englobar outras tags em seu conteúdo, como textos, imagens ou títulos. Exemplo:

    <**div style="height:100px; overflow:hidden"**>
        <**img src="https://pixabay.com/pt/photos/c%C3%B3digo-html-digital-codifica%C3%A7%C3%A3o-1076536/"
         alt="código HTML" width="100%"**>
    <**/div**>  

- _**<**section**>**_ - Uma seção de um documento, geralmente, contém título; pode ser utilizada para descrever seções/tópicos de um documento.Exemplo:

    <**section**>
        <**h3**>Resumo<**/h3**>
        <**p**>Aqui, veremos algumas tags importantes do body, como: header, nav, section, article e footer,
       além de algumas dicas.<**/p**>
        <!-- tag article aninhada aqui -->
    <**/section**>

- _**<**article**>**_ - É utilizada para um conteúdo independente, por exemplo, uma postagem ou artigo. É recomendado identificar utilizando um título.Exemplo:  

    <**article**>
        <**h4**>Dicas<**/h4**>
        <**p**>As tags abordadas aqui são importantes, mas não são as únicas. Pesquise outras tags e seus
       atributos e mantenha-se sempre informado.<**/p**>
    <**/article**>  

- _**<**footer**>**_ - Define o rodapé e geralmente contém informações de autoria (nome e contato do autor) e data de criação do conteúdo.  

    <**footer**>
        <**div style="float:left"**>
            <**p**>autor: SENAI-SP<**/p**>
        <**/div**>
        <**div style="float:right"**>
            <**p**>março de 2021<**/p**>
        <**/div**>
    <**/footer**>

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Formatação de texto e títulos

- _**<**b**> ou <**strong**>**_ - coloca o texto em negrito 

- _**<**i**>**_ - coloca o texto em italico 

- _**<**u**>**_ - coloca o texto em sublinhado

- _**<**em**>**_ - coloca o texto em enfase  

- _**<**hr**>**_ - cria uma linha que pode ser estilizada  

<**hr style="width:50%;height:3px;background-color:red"**>   

- _**<**br**>**_ - quebra uma linha

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Listas

- As listas desordenadas são iniciadas com a tag <**ul**> e cada item dessa lista é marcado com um bullet <**li**>.

    Este tipo de lista é representado por pontos na frente de cada elemento da lista, sem uma numeracao ou algo do tipo. Exemplo:

<**ul**>Lista desordenada
    <**li**>item 1<**/li**>
    <**li**>item 2<**/li**>
    <**li**>item 3<**/li**>
<**/ul**>

As listas ordenadas são iniciadas com a tag <**ol**> e cada item é marcado com números <**li**>, por padrão.   

<**ol**>Lista ordenada (padrão)
    <**li**>item 1<**/li**>
    <**li**>item 2<**/li**>
    <**li**>item 3<**/li**>
<**/ol**>  

Para marcar os itens com letras, utilize a tag <ol type="a"> e para marcar com números romanos, <ol type="I">.

<**ol type="a"**>Lista ordenada com letra
    <**li**>item 1<**/li**>
    <**li**>item 2<**/li**>
    <**li**>item 3<**/li**>
<**/ol**>  

<**ol type="I"**>Lista ordenada com número romano
    <**li**>item 1<**/li**>
    <**li**>item 2<**/li**>
    <**li**>item 3<**/li**>
<**/ol**>  

- As listas de definição são iniciadas com a tag <dl>, seguida de <dt> e <dd>

<**dl**>Lista de definição
    <**dt**>tag head<**/dt**>
    <**dd**>tag title<**/dd**>
    <**dd**>tags meta<**/dd**>
    <**dt**>tag body<**/dt**>
    <**dd**>tag header<**/dd**>
    <**dd**>conteúdo site<**/dd**>
    <**dd**>tag footer<**/dd**>
<**/dl**>

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Etiquetas para links e Hiperligacao

- Etiquetas para links, também chamadas de âncoras, são criadas para que o usuário, ao realizar uma ação, seja direcionado para uma página interna ou externa específica. Usar # entre aspas duplas no href (href="#")  significa que não irá direcionar para nenhum local.

É possível inserir etiquetas em qualquer elemento da página, como textos, títulos, imagens e botões. Para isso, basta utilizar a tag <a>, que possui um atributo de href no qual será inserido o valor referente ao endereço para onde o usuário será direcionado ao clicar.

    A tag <**a**> cria uma hiperligação entre a área clicável e o link 

Veja um exemplo de código:

<**nav id="menu"**>
    <**a href="index.html"**>home<**/a**>
<**/nav**>

- <**link**> - Nela, é possível adicionar um recurso interno ou externo, como chamar um arquivo CSS. Essa tag é mais utilizada para vincular folhas de estilo.Exemplo:  

<**link rel="stylesheet" href="estilo.css"**>

- _**target="_self"**_ - abre na mesma página (é o padrão, se a target não for definida);  

- _**target="_blank"**_ - abre em uma nova página;  

- _**target="_parent"**_ - abre em seu elemento pai, ou seja, no próximo nível acima; caso não haja um próximo nível, adota o padrão (self);  

- _**target="_top"**_: abre na janela toda.  

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Tabela

- A tabela é iniciada pela tag <**table**>, seguida da tag <**tr**>, que representa as linhas, e é formada pelas células, representadas pela tag <**td**>.  

<**thead**> - É o cabeçalho da tabela, tudo dentro desta tag será formatado apenas na primeira linha da tabela.  

<**tbody**> - É o corpo da tabela, tudo que será formatado dentro desta tag só se aplicará as demais linhas.  

<**table style="border: 2px solid black; padding: 3px"**>
    <**thead**>
        <**tr style="background-color: #cccccc; border:1px"**>
            <**th style="border: 1px solid grey; padding: 5px"**>Cursos Técnicos - SENAI<**/th**>
            <**th style="border: 1px solid grey; padding: 5px"**>Pós-Técnico<**/th**>
            <**th style="border: 1px solid grey; padding: 5px"**>Faculdade<**/th**>
            <**th**>Pós-Técnico<**/th**>
        <**/tr**>
    <**/thead**>
    <**tbody**> 
        <**tr**>
            <**td**>Front-End<**/td**>
            <**td**>Automação – Institucional<**/td**>
            <**td**>Gestão em Engenharia<**/td**>
            <**td**>Alimentos e bebidas<**/td**>
        <**/tr**>
    <**/tbody**>
<**/table**>

    - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Formulários

<**form**> - inicia estrutura de formulário

<**label**> - É a legenga que acompanha o input, geralmente o nome da informação.

<**for**> - É um atributo da tag  cujo objetivo  é permitir que, quando o usuário clique na palavra representada no <**label**>, selecione o input.

Isto ocorre pois o valor do **for** é ligado valor do **id**. Exemplo:

<**label for="name"**>Nome<**/label**>
<**input type="text" id="name"**>  

Desta forma, quando o usuário clicar na <**label**> "Nome", selecionará o input de texto.

  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Inputs

- _**<**input type="text"**>**_ - Este input cria um campo para digitação de texto.    

- _**<**input type="button"**>**_ - Este input cria um botão clicável que pode acionar alguma função do navegador ou chamar uma ação.  

- _**<**input type="checkbox"**>**_ - Este input cria uma checkbox que é clicável e tem dois estados.  

- _**<**input type="date"**>**_ - Este input cria um calendário onde o usuário pode selecionar datas.  

- _**<**input type="email"**>**_ - Este input cria uma área para digitação de e-mail, textos sem o @ não são considerados type email.  

- _**<**input type="file"**>**_ - Este input cria uma área para o upload de arquivos.  

- _**<**input type="number"**>**_ - Este input cria uma área para a digitação numérica.  

- _**<**input type="password"**>**_ - Este input cria uma área para a digitação de senhas. Os caracteres aparecem ocultos.  

- _**<**input type="radio"**>**_ - Este input cria uma bolinha clicável, muito parecida coma checkbox, mas só pode ter uma opção de saída dentre os elementos apresentados. Nunca poderá selecionar mais de um.

- _**<**input type="range"**>**_ - Este input cria uma reguá variável onde o usuário pode clicar e arrastar até chegar no valor desejado.  

- _**<**input type="search"**>**_ - Este input cria uma área de pesquisa onde o usuário pode pesquisar conteúdos dentro do site.  

- _**<**input type="submit"**>**_ - É utilizado para que o usuário possa enviar uma entrada.  

- _**<**input type="tel"**>**_ - É utilizado para que o usuário possa enviar uma entrada cujo valor seja numérico.  

  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Inputs Atributos

- _**maxlenght**_ - define um tamanho máximo para o input. Exemplo:  

<**input type="text"  maxlength="15"**>  

Neste caso o tamanho do texto inserido tera no maximo 15 caracteres.  

- _**required**_ - É um atributo que torna o campo obrigatório, impossibilitando o envio do formulário sem o preenchimento deste campo.  

- _**autocomplete**_ - Quando o usuário preenche o campo e envia o formulário, os dados ficam salvos; assim, caso ele queira enviar o formulário novamente, não é necessário redigitar todos os dados.    

Exemplo:  

<**input type="text" id="name" name="name" maxlength="15" required autocomplete**>      


- _**readonly**_ - não permite alterações no campo value do input, ou seja, o que já está lá não pode ser alterado. Exemplo:  

<**input type="email" value="example@example.com" readonly**>    

Neste cado o email "example@example.com" não poderia ser alterado pelo usuário.   

- _**readonly**_ - não permite alterações no campo value do input, ou seja, o que já está lá não pode ser alterado. Exemplo:  

- _**<**textarea**>**_ - Cria um input de caixa de texto onde o usuário pode digitar  

        Esta função acompanha alguns atributos que são normalmente utilizados juntamente com ela:  

**rows** - define a quantidade de linhas e altera a altura do textarea.     
**cols** - define a quantidade de colunas e altera a largura do textarea.     
**minlength** - define a quantidade mínima de caracteres de um input.    
**placeholder** - placeholder: define uma mensagem dentro da área de texto.    

Exemplo:    

<**textarea id="mensagem" name="mensagem" rows="5" cols="20" maxlength="200" minlength="2" placeholder="Digite aqui sua mensagem" required autocomplete**>  

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Inserção de Imagem

        A maneira mais comum de inserir imagens é utilizando as tags figure e img.

- _**figure**_ - além de agrupar imagens, pode adicionar ilustrações, diagramas e listagens. A tag **figcaption** define uma legenda para a imagem.  
<**figure class="banner-home"**>  

- _**img**_ - A tag img possui o atributo src (source), que é a fonte ou o caminho – local ou online – da imagem. O atributo **alt** é uma breve descrição da imagem não mostrada no navegador, mas interpretada pelo browser.    
<**img src="imagem.jpg" alt=" banner da home" width="50%" **>  

O tamanho da imagem pode ser definido pelos atributos width (largura) e height (altura), usando medidas fixas em pixels ou em porcentagem.Então, se o tamanho da imagem for definido em px (pixels), o tamanho da imagem ficará fixo e a imagem terá barras de rolagem, caso seja acessada em dispositivos com telas menores. Usando a porcentagem, o tamanho da imagem se adapta ao tamanho da tela do dispositivo, mantendo a proporção. Por ser mais responsiva, a porcentagem é a medida mais utilizada.  

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Áudio

- As tags de <**audio**> e <**video**> do HTML5 foram criadas para acabar com a dependência de plugins de reprodução. Com elas, podemos inserir e configurar atributos para essas tags do mesmo modo que fazemos com a tag img. Analise a seguir um exemplo de código.  

- _**controls**_ - permite ao usuário controlar a reprodução do áudio, podendo iniciar, pausar e controlar o volume.  

- _**Autoplay**_ - o áudio irá iniciar automaticamente assim que a página for carregada. Pode não funcionar em alguns navegadores.  

- _**Muted**_ - o áudio será silenciado.  

- _**Played**_ - atributo que indica o tempo em que o áudio foi reproduzido.  

Exemplo:  

<**audio**>  
    <**source src="audio.mp3" type="audio/mpeg"**>  
<**/audio**>  

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Vídeo

Para adicionar um arquivo de vídeo em uma página HTML, utilize a tag <**video**> para incorporar o código.  

Além da tag <**video**>, é necessário adicionar o atributo width (largura), height (altura) e controls. Assim como a tag <**audio**>, o atributo controls permite ao usuário controlar a reprodução do vídeo.  

Dentro da tag <**video**> está aninhada a tag source, que determina a fonte do vídeo, que pode ser um caminho local ou uma URL. Veja um exemplo a seguir.  

<**video width="320" height="240" controls**>  
    <**source src="video.mp4"**>  
<**/video**>  

- _**Autoplay**_ - atributo booleano para que o vídeo possa ser executado
automaticamente.    

- _**Loop**_ - com esse atributo, o vídeo voltará ao início,
automaticamente, quando terminar.  

- _**Muted**_ - o vídeo terá o áudio silenciado.  

- _**Preload**_ - com esse atributo, o usuário escolhe o momento em que
o vídeo irá ser carregado, ou seja, ele dá o play. Nesse atributo, é
possível sugerir valores, podendo ser:  

Auto: o navegador carrega o vídeo assim que a página é
carregada;  

Metadata: o vídeo carrega apenas os metadados;  

None: o vídeo não deve ser pré-carregado.  

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### CSS

    Existem 3 formas de trabalhar com o CSS

- _**inline**_ - O CSS é passado como um atributo na tag.  

<**p style = "font-size: 30px; color: red**><**/p**>  

- _**interno**_ - O CSS é passado no documento HTML.  

<**style**>  
    h1{  
        font-size: 30px;  
    }
<**/style**>  

- _**interno**_ - Um arquivo com a extensão .css é criado separadamente e é chamado no cabeçalho do HTML pela tag <**link**>. Assim, o CSS criado pode ser aplicado a qualquer página, o que otimiza o tempo de carregamento dos elementos. Neste curso, trabalharemos com o estilo externo.

<**link rel ="stylesheet" type="text/css" href="style.css"**>  

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### CSS Seletores

- _**class e id**_ - Nas tags do código HTML, adicionamos uma class ou um id. Lembre-se de que é possível ter diversas class na mesma página, porém o id é único. As imagens a seguir mostram um exemplo de código com uma estrutura de menu que utiliza o seletor id e a sua estilização:

        id é usada a # na frente do valor e class é utilizado o .
Observe como chamar elementos pai e filho no CSS.  

O elemento pai, a tag que está agrupando as demais, é chamado normalmente. Para chamar a tag filha, é necessário chamar o elemento pai anteriormente.Exemplo:  

.menu .linkmenu{  
    color:red;  
}  

- _**varios elementos**_ - É possível chamar vários elementos sem uma class ou id, separando-os por vírgulas, desde que sejam elementos pai.  

p, h1, h2{  
    color: red;  
}   

     No caso de Elementos filho:

.menu .linkmenu, h3, #txt1 a, .titulos {  
    color: black;  
}
     Ainda podemos chamar um seletor (class ou id) e passar o tipo do atributo dele, Exemplo:

#menu a.linkMenu{
    color: red;
}  

    Uma outra forma de você chamar um seletor é pela pseudoclasse, ou seja, é aplicado um estado especial para um elemento selecionado. Por exemplo:

• :hover: Seu CSS é alterado quando o usuário passa o
cursor (mouse) por cima do elemento; por exemplo, ao
posicionar o cursor sobre um link, uma cor de
destaque surgirá.
• :active: é utilizado quando o link está ativo.
• :visited: o destaque indica quando o link já foi visitado
pelo usuário.
• :focus: quando o elemento recebe foco, ou seja,
quando o usuário está utilizando um teclado ou mouse
e o elemento selecionado recebe uma cor de
destaque; por exemplo, ao preencher um formulário.   

Exemplos:  

https://www.w3schools.com/cssref/tryit.asp?filename=trycss_sel_hover  
https://www.w3schools.com/cssref/tryit.asp?filename=trycss_sel_active  
https://www.w3schools.com/cssref/tryit.asp?filename=trycss_sel_visited  
https://www.w3schools.com/cssref/tryit.asp?filename=trycss_sel_focus

### CSS Comandos

- _**width**_ - no exemplo, a tag <**nav**> revela que o conteúdo vai ocupar 100% da largura disponível da tela. Ainda pode ser definidos em pixels.   

- _**Height**_ - faz o mesmo com a altura  

- _**Justify-content**_ - Justify-content: alinha os itens quando os elementos não utilizam todo o espaço horizontal.**Center (centralizado)**, mas poderia ser **flex-start (à esquerda)**, **flex-end (à direita)**, **space-between (distribuído simetricamente** na largura disponível), entre outros.  

- _**Display**_ - propriedade que especifica o comportamento de exibição. O valor **flex** torna a tag <**nav**> uma tag pai flexível, comportamento herdado por suas tags filhas.

- _**margin**_ - Utilizamos margin, ou margem, para dar espaçamento fora do conteúdo.  

- _**padding**_ - Já o padding, ou preenchimento, é utilizado para espaçamento dentro do conteúdo.

- _**border**_ - É o delimitante de do que fica dentro ou fora.

- _**class or id a:hover**_ - delimita uma alteracao que sera feita apenas enquanto o mouse estiver em cima do elemento.

.class a:hover {
    background-color ="green"
}


- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### CSS Integracao com o HTML

- _**link**_ - Utilizado para ligar um elemento externo ao HTML.  

rel: relação entre link e documento.  
type: especifica o tipo de mídia do documento/recurso vinculado.  
href: define o caminho do arquivo.   

        Atributos não usuais  

hreflang: especifica o idioma do texto no documento vinculado.
sizes: determina o tamanho do recurso vinculado para ícones. Usado apenas para o rel=“icon”.  

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### CSS Estilos de Fonte

- _**Font-family**_ - A propriedade font-family define o tipo da fonte e é utilizada para atributos de textos. Se houver algum problema com a primeira fonte a fonte seguinte será selecionada.  

- _**Font-style**_ - Define o estilo da fonte, como normal, italic ou oblique.  

- _**Font-variant**_ - transforma a letra da fonte em todas minusculas, maiusculas ou muda o tamanho da letra.  

- _**Font-weight**_ - Define a espessura da fonte, ou seja, o quão “pesado” ou grosso será o traçado. A fonte pode ter valor normal ou bold, porém, é possível determinar um valor entre 100 e 900. Quanto menor o número, mais fino será o traço da fonte.

        Outra maneira possível de editar uma fonte é chamando a propriedade fonte passando alguns valores, como exemplificado no exemplo.

font: italic bold 30px arial, sans-serif;  

Podemos ver no exemplo o **font-style**, **font-weight**, **font-size** e **font-family**.  

    Ao posicionar o mouse sobre a propriedade font, será apresentada uma sequência a ser seguida para adicionar os valores.

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Estilos de Linhas (borda)

    As principais propriedades para estilizar as bordas das linhas são:

Dotted: pontilhada.  
Dashed: tracejada.  
Solid: sólida.  
Double: dupla.  
Groove: com sulcos 3D; o efeito depende do valor da cor da borda.  
Ridge: 3D estriada; o efeito depende do valor da cor da borda.  
Inset: inserção 3D; o efeito depende do valor da cor da borda.  
Outset: inserção 3D; o efeito depende do valor da cor da borda.  
None: sem borda.  
Hidden: define uma borda oculta.  
Mixed: composição de diferentes bordas.  

<**p class = "dotted"**> Texto aqui.<**/p**>  
**p.dotted {border-style:dotted}**  

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

### Eventos  

    Eventos são ações que ocorrem em um elemento da página web, por exemplo, quando o usuário termina de preencher um formulário, clica no botão “enviar” e aguarda uma mensagem de confirmação para saber se seu formulário foi de fato enviado. Após o clique, pode aparecer uma tela ou uma mensagem com a confirmação de que o formulário foi enviado.
**Alguns eventos são codificados na linguagem de programação JavaScript, enquanto outros não.**  

- _**attr()**_ - Utilizada para obter o valor de um elemento selecionado.  

 https://www.w3schools.com/cssref/tryit.asp?filename=trycss_func_attr  

- _**calc()**_ - Executa cálculos para determinar os valores das propriedades CSS.  

https://www.w3schools.com/cssref/tryit.asp?filename=trycss_func_calc  


- _**cubic-bezier()**_ - Define uma curva de Bézier cúbica.  

https://www.w3schools.com/cssref/tryit.asp?filename=trycss_func_cubic-bezier  


- _**hsl()**_ - Define as cores utilizando o modelo Hue, Saturation, Lightness (HSL).  

https://www.w3schools.com/cssref/tryit.asp?filename=trycss_func_hsl  


- _**hsla()**_ - Define cores utilizando o modelo Hue, Saturation, Lightness, Alpha (HSLA).  

https://www.w3schools.com/cssref/tryit.asp?filename=trycss_func_hsla  

- _**linear-gradient()**_ - Define um gradiente linear como imagem de fundo. Defina pelo menos duas cores para compor o gradiente (de cima para baixo).  

https://www.w3schools.com/cssref/tryit.asp?filename=trycss3_gradient-linear  

- _**radial-gradient()**_ - Define um gradiente radial como imagem de fundo. Defina pelo menos duas cores para compor o gradiente (do centro para as bordas).  

https://www.w3schools.com/cssref/tryit.asp?filename=trycss3_gradient-radial  

- _**repeating-radial-gradient()**_ - Repete um gradiente radial.  

https://www.w3schools.com/cssref/tryit.asp?filename=trycss3_gradient-radial_repeating  

- _**rgb()**_ - Define as cores usando o modelo Red, Green, Blue (RGB).  

https://www.w3schools.com/cssref/tryit.asp?filename=trycss_func_rgb  

- _**var()**_ - Insere o valor de uma propriedade personalizada.  

https://www.w3schools.com/cssref/tryit.asp?filename=trycss_func_var  





































