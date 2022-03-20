// primeiro contador da lista de alunos, dizendo se e par ou nao e mostrando o numero
console.log("\n")
let numeroDeAlunos = 10;

for (let contador = 0; contador <= numeroDeAlunos; contador++) {
   //console.log(contador);
   if (contador === 0) {
       console.log("O número atual é Zero")
       } else if (contador%2 == 0) { 
        console.log("O número " + contador +" é Par")
       } else {
           console.log("O número " + contador +" é Ímpar") 
    }
}

console.log("\n")

// demonstracao de for of
//percorre a lista de alunos mostrando cada variavel dentro do vetor de cada vez
let listaDeAlunos = ["Marcelo","Juh", "Cleber", "Wesley","Adriano"]
for (const aluno of listaDeAlunos){
console.log(aluno)
}

console.log("\n")

// demontracao do for each
//faz algo para cada elemento do array
listaDeAlunos.forEach(aluno => {
    console.log(aluno)
});

console.log("\n")

// Executa uma funcao enquanto uma condicao for atendida, nao executa a primeira vez caso nao haja a condicao
// necessita a declaracao de uma variavel para ser usado como contador
let contador = 0

while (contador<= numeroDeAlunos) {
    if (contador === 0) {
        console.log("O número atual é Zero")
        } else if (contador%2 != 1) { 
         console.log("O número " + contador +" é Par")
        } else {
            console.log("O número " + contador +" é Ímpar")}
    contador++
}

console.log("\n")

// executa a funcao pelo menos uma vez antes de checar a condicao
// tbm necessita de uma variavel declarada que e o let do exemplo de while

let gg = 0

do {  
    if (gg === 0) {
    console.log("O número atual é Zero")
    } else if (gg%2 != 1) { 
     console.log("O número " + gg +" é Par")
    } else {
        console.log("O número " + gg +" é Ímpar")}
    gg++
} while (gg <= numeroDeAlunos);

console.log("\n")

// exemplificacao do operador AND (E) simbolo &&
//true && true > true
//true && false > false
//false && true > false
//false && false > false

for (let contador = 0; contador <= numeroDeAlunos; contador++) {
    //console.log(contador);
    if (contador == 0 ) {
        console.log("O número atual é Zero")
        } else if (contador%2 == 0 && contador > 5) { 
         console.log("O número " + contador +" é Par e maior que 5")
        } else if (contador%2 == 0 ) { 
            console.log("O número " + contador +" é Par")
        } else {
            console.log("O número " + contador +" é Ímpar") 
     }
 }
 
 // exemplificacao do operador OR (OU), simbolo ||
 //true || true > true
//true || false > true
//false || true > true
//false || false > false

// exemplificacao do operador NAO (NOT), simbolo !
//



