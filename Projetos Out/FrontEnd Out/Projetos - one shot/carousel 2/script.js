const imgs = document.getElementById('img')
const img = document.querySelectorAll("#img img")
alert(img.lenght)

let idx = 0;

function carrossel1(){
    idx++;

    //if(idx > 4 -1){
     //   idx = 0;
    //}
    imgs.style.transform = `translateX(${-idx*180}px)`
}


function carrossel2(){
    idx++;

    //if(idx > 4 -1){
     //   idx = 0;
    //}
    imgs.style.transform = `translateX(${-idx*180}px)`
}

setInterval(carrossel2,1000)