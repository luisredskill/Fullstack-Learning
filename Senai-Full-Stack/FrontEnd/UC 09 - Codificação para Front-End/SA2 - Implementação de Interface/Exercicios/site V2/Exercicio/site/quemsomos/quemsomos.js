let carrossel = document.getElementById("carrossel")
let contador = 0


function carrossel1() {
    contador++;
    if (contador > 2) {
        contador = 0
    }
    carrossel.style.transform = `translateX(${-contador*500}px)`

}

setInterval(carrossel1, 3000)