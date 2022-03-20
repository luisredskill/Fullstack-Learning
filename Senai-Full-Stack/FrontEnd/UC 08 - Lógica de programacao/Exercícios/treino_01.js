// ver se tem 10 pecas ou mais para possibilitar o cadastro
// ver se a peca tem 100 gramas ou mais
// checar vetor para cada variavel se o nome tem mais de 3 caracteres

//const pecas = ["Limpador","BCG","CWH","Rosca","EJS","Cardan","Oil","Pneu","Parafuso"]
//const pecas = ["Limpador","BCG","CWH","Rosca","EJS","Cardan","Oil","Pneu","Parafuso","Cadeira"]
const pecas = ["Limpador","BCG","CWH","Rosca","EJS","Cardan","Oil","Pneu","Parafuso","Cadeira","Sabonete"]
let peso = ["50","60","120","150","85","99","110","250","5","60","115"]

console.log("\n")
console.log("Existem "+ pecas.length +" peças cadastradas")

if (pecas.length < 10) {
    console.log("Ainda podem ser cadastradas "+ (pecas.length - 10) *-1  + " para totalizar o limite de 10 peças.")
} else if (pecas.length == 10) {
    console.log("Número máximo de peças atingido "+ pecas.length+"/10")
  }else {
      console.log("Número de peças em excesso "+ pecas.length+"/10")
  }
  
console.log("\n")
console.log("segue a lista de peças e seus respectivos pesos ")
console.log("\n")

let contador = 0
   pecas.forEach (g =>{
       console.log(g +" "+ peso[contador]+" gramas")
       contador++
       if (peso[contador] >= 100 && g.length > 3) {
           console.log("Esta peça PODE ser cadastrada")
       } else if (peso[contador] >= 100 && g.length <= 3) {
           console.log("Esta peça NÃO pode ser cadastrada, motivo: NOME INADEQUADO")
       } else {
        console.log("Esta peça NÃO pode ser cadastrada, motivo: PESO INSUFICIENTE")
       }
       console.log("\n")
   }) 



