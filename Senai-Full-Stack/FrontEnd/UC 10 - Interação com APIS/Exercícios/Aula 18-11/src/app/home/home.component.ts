import { Component, OnInit } from '@angular/core';
import { Banner } from '../models/banner';
import { BannerService } from '../services/banner.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  bannertext = [] as Banner[];

  constructor(private bannerService: BannerService) { };


  ngOnInit(): void {
    this.carregarBanner()
    
    }

  carregarBanner(){
    this.bannerService.getBannerinfo().subscribe((bannerRecebidos:Banner[]) => {
      this.bannertext = bannerRecebidos
      console.log(this.bannertext)

    })

}}

