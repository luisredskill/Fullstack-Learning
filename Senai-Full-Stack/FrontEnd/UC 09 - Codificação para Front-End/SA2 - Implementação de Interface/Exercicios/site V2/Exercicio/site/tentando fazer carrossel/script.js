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