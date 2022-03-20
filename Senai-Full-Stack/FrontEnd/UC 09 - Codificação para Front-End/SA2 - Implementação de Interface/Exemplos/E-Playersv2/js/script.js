let email = document.getElementById("campo-email")


function enviarEmail(){
    let emailDigitado = email.value
    console.log(emailDigitado)

}

function renderizarNoticias() {
    let listaNoticias = [
        {
            titulo: "Brasil leva 1 gol no inicio do jogo",
            descricao: "Houve uma falha na defesa brasileira, que deixou o atacante adversário cara a cara com o goleiro."
        },
        {
            titulo: "O dólar está alto",
            descricao: "O dólar está em alta há muito tempo."
        },
        {
            titulo: "Brasil leva 1 gol no inicio do jogo",
            descricao: "Houve uma falha na defesa brasileira, que deixou o atacante adversário cara a cara com o goleiro."
        },
        {
            titulo: "O dólar está alto",
            descricao: "O dólar está em alta há muito tempo."
        },
        {
            titulo: "Brasil leva 1 gol no inicio do jogo",
            descricao: "Houve uma falha na defesa brasileira, que deixou o atacante adversário cara a cara com o goleiro."
        },
        {
            titulo: "O dólar está alto",
            descricao: "O dólar está em alta há muito tempo."
        },
    ]
    let espaco = document.getElementById("espaco-noticias")
    let template = ""
    for (let index = 0; index < listaNoticias.length; index++) {
        const noticia = listaNoticias[index];

        console.log("Noticia")

       

        template += `<div class="cardnews">
        <img src="img/cardnews.jpg" alt="Foto da jogadora profissional">
        <h3>${noticia.titulo}</h3>
        <p>${noticia.descricao}</p>
    </div>`
        espaco.innerHTML = template;
    }
    console.log()
}