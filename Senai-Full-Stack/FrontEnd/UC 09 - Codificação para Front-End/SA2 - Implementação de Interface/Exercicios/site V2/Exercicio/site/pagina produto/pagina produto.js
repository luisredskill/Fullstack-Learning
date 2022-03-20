const imgs = document.getElementById("img")
const img = document.querySelectorAll(".produto")

let idx = 0;

function carrossel1(){
   idx ++ ;
    if(idx > img.length - 5){
        idx = 0
    }
    imgs.style.transform = `translateX(${-idx*190}px)`
}

function carrossel2(){
   if(idx == 0 ){

   }
   else{
    idx--;
    imgs.style.transform = `translateX(${-idx*190}px)`
    
    }
}

//setInterval(carrossel1,1800)

let produtos = document.getElementById("produtos")
let produtosQ = document.querySelectorAll(".produto")

let contador = 0

function setaESQ(){
    if (contador != 0) {
        contador--;
        produtos.style.transform = `translateX(${-contador*180}px)`
    } 
}

function setaDIR(){

 

    contador++;
    if (contador > produtosQ.length - 6) {
        contador = 0
} 
        produtos.style.transform = `translateX(${-contador*180}px)`
    

}