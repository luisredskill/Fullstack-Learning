function carregar() {
    var date = new Date()
    var hora = date.getHours()
    var msg = document.getElementById("msg")
    var foto = document.getElementById("foto")
    var sla = document.getElementById("sla")
    msg.innerHTML = `Agora são ${hora} horas.`

    if (hora <= 6) {
        foto.src = "noite.png"
        document.body.style.background = '#023745'
        sla.innerHTML = "Boa Madrugada!"
    } else if (hora < 12) {
        foto.src = "manha2.png"
        document.body.style.background = '#D896A9'
        sla.innerHTML = "Bom Dia!"
    } else if (hora < 18) {
        foto.src = "tarde.png"
        document.body.style.background = `#DF9F65`
        sla.innerHTML = "Boa Tarde!"
    } else {
        foto.src = "noite.png"
        document.body.style.background = '#023745'
        sla.innerHTML = "Boa Noite!"
    }
}