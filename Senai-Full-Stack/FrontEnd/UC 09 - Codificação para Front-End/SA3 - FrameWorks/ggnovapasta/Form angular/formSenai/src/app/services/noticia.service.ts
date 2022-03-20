import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Noticia } from '../models/noticia';

@Injectable({
  providedIn: 'root'
})
export class NoticiaService {
//Armazena o endere;o da api
url = "http://localhost:3000/noticias"
//chama o metodo httpClient que faz com que comunica com a api
  constructor(private httpClient: HttpClient) { }
//variavel que armazena as configuracoes de header da requisicao, neste caso ele diz que o arquivo que vai ser mandado e um json
  httpOptions ={
    headers: new HttpHeaders({'Content-Type': 'application/json'})
  }
//metodo get, vai trazer as noticias da API
  getNoticias(): Observable<Noticia[]>{
    return this.httpClient.get<Noticia[]>(this.url)
  }
}
