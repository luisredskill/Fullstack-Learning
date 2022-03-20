import { Component, OnInit } from '@angular/core';
import { Noticia } from '../models/noticia';
import { NoticiaService } from '../services/noticia.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

   noticias = [] as Noticia[]

  constructor(private noticiaService: NoticiaService) { }

  ngOnInit(): void {
    this.carregarNoticias();
  }
  carregarNoticias(){
    this.noticiaService.getNoticias().subscribe( (noticiasRecebidas: Noticia[])=> {
      this.noticias = noticiasRecebidas;
      console.log(this.noticias)
    } )
  }
}
