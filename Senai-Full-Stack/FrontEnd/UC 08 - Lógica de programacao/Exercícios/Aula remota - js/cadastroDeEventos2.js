let a = new Date()
let ListaDeParticipantes = new Array(10)
let dia = 31
let mes = 8
let ano = 2021


if (ano > a.getFullYear()) {
    console.log("Cadastro pode ser efetuado:ano")
} else if (ano < a.getFullYear()) {
    console.log("Data invalida:ano")
} else {
    if (mes > (a.getMonth() + 1)) {
        console.log("Cadastro pode ser efetuado:mes")
    } else if (mes < (a.getMonth() + 1)) {
        console.log("Data invalida:mes")
    } else {
        if (dia > a.getDate()) {
            console.log("Cadastro pode ser efetuado:dia")
        } else {
            console.log("Data invalida:dia")
        }
    }
}
