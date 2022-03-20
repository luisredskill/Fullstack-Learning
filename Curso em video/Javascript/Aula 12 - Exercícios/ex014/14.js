function carregar() {
    var msg = window.document.getElementById("msg")
    var img = window.document.getElementById("imagem")
    var data = new Date()
    var hora = data.getHours()
    msg.innerHTML = `Agora são ${hora} horas. `
    if (hora>=0 && hora <12) {
        img.src = `manha2.png`
        document.body.style.background = '#D896A9'
    } else if (hora >= 12 && hora < 18){
        document.body.style.background = '#DF9F65'
img.src = `tarde.png`
    } else{
img.src = `noite.png`
document.body.style.background = '#023745'

    }
}
