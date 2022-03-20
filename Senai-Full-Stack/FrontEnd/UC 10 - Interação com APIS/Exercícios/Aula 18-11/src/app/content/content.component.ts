import { LocationStrategy } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Login } from '../models/login';
import { LoginService } from '../services/login.service';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent implements OnInit {

  constructor(private router: Router, private LoginService: LoginService) { }

  ngOnInit(): void {
  }

  loginModel = new Login();

  mensagem = ""

  onSubmit() {

    const Blacklist:string[] = ["select ", "from ", "drop ", "or ", "having ", "group ", "insert ", "by ", "exec ", "\"", "\'", "--", "#", "*", ";"]


    Blacklist.forEach(blackword =>{
if(this.loginModel.email.toLocaleLowerCase().includes(blackword)){
  this.mensagem = "Dados inválidos"

  return;
}
    });

    this.LoginService.login(this.loginModel).subscribe((response) => {
      this.mensagem = "Login com sucesso!"
      this.router.navigateByUrl("/")
    }, (error) => {
this.mensagem = error.error;
    }
    )
  }
}


