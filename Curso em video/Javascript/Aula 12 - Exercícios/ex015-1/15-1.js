function Verificar() {
    var agora = new Date()
    var ano = agora.getFullYear()
    var nasc = document.getElementById("txtnasc").value
    var nome = document.querySelector("#txtnome").value
    var res = document.querySelector("div#res")
    var idade = Number(ano - nasc)

    if (nasc > ano || nasc == 0) {
        res.innerHTML = `[Erro] a idade inserida foi de ${idade}, esta idade é inválida!`

        /* }else if (nome.length < 3 || nome.length > 20) {
             `[Erro] o nome inserido foi de ${nome}, este nome é inválido!` (Fazer funcionar dps)*/
    }
    else {
        var sex = document.getElementsByName("sex")
        var genero = ""
        var foto = document.getElementById("foto")


        if (sex[0].checked) {
            genero = "homem"
            if (idade < 10) {
                foto.setAttribute("src", "criancahomem.png")
            } else if (idade < 20) {
                foto.setAttribute("src", "jovemhomem.png")
            } else if (idade < 50) {
                foto.setAttribute("src", "adultohomem.png")
            } else {
                foto.setAttribute("src", "idosohomem.png")
            }
        }
        else {
           
            genero = "mulher"

            if (idade < 10) {
                foto.setAttribute("src", "criancamulher.png")
            } else if (idade < 20) {
                foto.setAttribute("src", "jovemmulher.png")
            } else if (idade < 50) {
                foto.setAttribute("src", "adultomulher.png")
            } else {
                foto.setAttribute("src", "idosomulher.png")
            }
        }
    }
    res.innerHTML =  `Olá ${nome}, você é um ${genero} de ${idade} anos!`
}
