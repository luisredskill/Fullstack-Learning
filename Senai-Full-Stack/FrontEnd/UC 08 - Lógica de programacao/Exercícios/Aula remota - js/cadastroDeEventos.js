console.log("\n")

let dia = 4 // dia do evento
let mes = 9 // mes do evento
let ano = 2021 // ano do evento
let idade = 17 // idade do participante
let participantes = 78 // numero de participantes
let jeba = ["Maria","Carlos", "Ricardo", "Janaina", "Roberto","Julia"] // lista de participantes


if (ano > 2021) {
    console.log("Evento Cadastrado!")
} else if (ano < 2021) {
    console.log("Data invalida")
} else if (ano = 2021) {
    if (mes > 9) {
        console.log("Evento Cadastrado!")
    } else if (mes < 9) {
        console.log("Data invalida")
    } else if (mes = 9) {
        if (dia > 3) {
            console.log("Evento Cadastrado!")
        } else if (dia < 3) {
            console.log("Data invalida")
        } else {
            console.log("data invalida")
        }

    }
}
if (idade >= 18) {
    if (participantes < 100) {
        console.log("participante pode ser cadastrado")
    } else {
        console.log("numero de participantes atingiu o limite")
    }
} else {
    console.log("idade insuficiente")
}
console.log("segue a lista de participantes abaixo")
console.log("\n")

jeba.forEach(j => {
    console.log(j)
});



console.log("\n")


