# Conteúdo de suporte de comandos UC10 -Interação com APIs
-------------------------------------------------------------------------------

## app.module.ts

    faz a interação de módulos, no caso para interagir com apis precisamos do *HttpClientModule*, o arquivo deve ter as seguintes linhas:  

import { HttpClientModule} from '@angular/common/http';

Este operação importa uma classe de uma biblioteca. No caso, importa a classe *HttpClientModule* da biblioteca *http*.

Depois de importar o módulo, devemos declarar a existência dele no mesmo arquivo. Desta forma:  

 imports: [
   BrowserModule,
   HttpClientModule
]

Tenha atencao de que ele deve ser declarado depois do BrowserModule segundo a documentacao.

-------------------------------------------------------------------------------

## Services

    É uma classe que criaremos para interagir com a API trazendo informações, ele faz requisições Http.

para gerar um service devemos usar o comando *__ng generate service sua_pasta/seu_arquivo__*

assim serã criados dois arquivos *__seu_arquivo.service.ts__* e *__seu_arquivo.service.spec.ts__*.

Dentro do arquivo *__seu_arquivo.service.ts__*:

- O primeiro passo é colocar o endereço da API, para exemplo usaremos o servidor local do json-server. Este endereço vai dentro da estrutura export do arquivo como no exemplo abaixo:  
export class BannerService {

  url = "http://localhost:3000/banner"

  constructor() { }
}

Este tipo de estrutura permite trocar todas as urls do arquivo apenas trocando esta variável. Quando for necessario alterar, apenas sera necessario alterar esta variavel com a nova url.

- O segundo passo é criar uma dependência, uma variável que fará a ponte entre o serviço e o módulo criado anteriormente. Neste caso criaremos uma variável com o nome de *httpClient* que será o nosso serviço e terá a função de interagir com nossa API e este método será tipado como *HttpClient*, que por sua vez é a nossa classe responsável por trazer a funcionalidade ao serviço.

 constructor(private httpClient: HttpClient) { }

 - O terceiro passo e informar o tipo de arquivo que sera passado ao nosso projeto, neste caso informaremos que o tipo de arquivo sera do tipo json ao nosso arquivo, esta configuracao e passada ao header por padrao.  

  httpOptions = {
    headers: new HttpHeaders ({ 'Content-Type': 'application/json'})
  }  

  - O quarto passo é informar o método que ele utilizará para as requests do servidor, dentre elas, as mais famosas, que são GET/POST/PUT/DELETE.  

  Para isso usaremos uma estrutura de função que do tipo Observable, o tipo observable é uma tipagem que diz que o código pode continuar sendo executado mesmo sem as variáveis que a função precisa, ou seja, todo o código pode ser executado e a função com o Observable só será executada ao receber as variáveis necessárias, sem a necessidade de esperar as variáveis para continuar a execução do código.

  getBannerinfo(): Observable<Banner[]>{
    return this.httpClient.get<Banner[]>(this.url)
  }

-------------------------------------------------------------------------------

## Models

    A pasta models gera modelos de template, no caso deste exemplo criaremos a estrutura que tera no banner e que sera recebido do arquivo json. Neste arquivo devem ser declaradas as informacoes que serao pegas do arquivo json para que assim o angular reconheca o array que armazenara as informacoes do banner.

  Para isso devemos criar uma interface que sera responsavel por armazenar estes dados com o comando *__ng generate interface models/banner__*, este comando ira gerar um arquivo 

  export interface Banner {
   bannerA: string;
   bannerB: string;
   id: number;
}
























