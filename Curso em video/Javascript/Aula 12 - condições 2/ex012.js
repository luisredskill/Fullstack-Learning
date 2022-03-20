var agora = new Date()
var hora = agora.getHours() // retorna a hora exata segundo o servidor

console.log(`agora sao exatamente ${hora}`) // diz a hora
if (hora <12 && hora >= 6) { // mensagens de bom dia, boa tar e boa noite baseado na hora
    console.log(`Bom dia`)
} else if ( hora>=12 && hora <= 18) {
    console.log(`Boa tarde`)
} else {
    console.log(`Boa noite`)
}