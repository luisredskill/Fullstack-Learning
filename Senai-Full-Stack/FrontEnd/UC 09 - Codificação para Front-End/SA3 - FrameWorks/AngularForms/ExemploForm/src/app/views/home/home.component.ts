import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/user';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  userModel = new User("", "") 
  // como ja foi definido a classe User, devemos criar um objeto que ira 
  // pegar os dados e aloca-los, para isso precisavos de valores base para eles, mesmo que sejam em branco ""

  onSubmit(){
    console.log(this.userModel)
  }

}
