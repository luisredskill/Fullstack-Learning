
// Passador mais vendidos
const img1 = document.getElementById("img1")
const imgs1 = document.querySelectorAll(".imagem1")

let contador1 = 0
let size1 = 6
let size2 = 4

function passadorDIR1() {
    contador1++;

    if (contador1 > imgs1.length - size1) {
        contador1 = 0
    }
    img1.style.transform = `translateX(${-contador1 * 180}px)`
}



function passadorESQ1() {
    if (contador1 == 0) {

    } else {
        contador1--;
        img1.style.transform = `translateX(${-contador1 * 180}px)`
    }
}

// Passador PC GAMER

const img2 = document.getElementById("img2")
const imgs2 = document.querySelectorAll(".imagem2")

let contador2 = 0

function passadorDIR2() {
    contador2++;
    if (contador2 > imgs2.length - size1) {
        contador2 = 0
    }
    img2.style.transform = `translateX(${-contador2 * 180}px)`
}



function passadorESQ2() {
    if (contador2 == 0) {

    } else {
        contador2--;
        img2.style.transform = `translateX(${-contador2 * 180}px)`
    }
}

// Passador jogos 1

const img3 = document.getElementById("img3")
const imgs3 = document.querySelectorAll(".imagem3")

let contador3 = 0

function passadorDIR3() {
    contador3++;
    if (contador3 > imgs3.length - size2) {
        contador3 = 0
    }
    img3.style.transform = `translateX(${-contador3 * 259}px)`
}



function passadorESQ3() {
    if (contador3 == 0) {

    } else {
        contador3--;
        img3.style.transform = `translateX(${-contador3 * 259}px)`
    }
}

// Passador jogos 1

const img4 = document.getElementById("img4")
const imgs4 = document.querySelectorAll(".imagem4")

let contador4 = 0

function passadorDIR4() {
    contador4++;
    if (contador4 > imgs4.length - size2) {
        contador4 = 0
    }
    img4.style.transform = `translateX(${-contador4 * 259}px)`
}



function passadorESQ4() {
    if (contador4 == 0) {

    } else {
        contador4--;
        img4.style.transform = `translateX(${-contador4 * 259}px)`
    }
}

// responsividade//

window.addEventListener('resize', function () {
    let largura = window.innerWidth
    if (largura > 1120 && largura < 1350) {
        size1 = 5
        size2 = 3
    } else if (largura <= 1120) {
        size1 = 4
        size2 = 2

    } else {
        size1 = 6
        size2 = 4
    }


})

let largura = window.innerWidth
if (largura > 1120 && largura < 1350) {
    size1 = 5
    size2 = 3
} else if (largura <= 1120) {
    size1 = 4
    size2 = 2

} else {
    size1 = 6
    size2 = 4
}

window.addEventListener('resize', function () {
    if (largura <= 1120) {
        let element = document.getElementById("element")
        let element2 = document.getElementById("element2")
        element.classList.remove("-ccc")
        element.classList.add("ccc")
        element2.classList.remove("ccc")
        element2.classList.add("-ccc")

    }


})







