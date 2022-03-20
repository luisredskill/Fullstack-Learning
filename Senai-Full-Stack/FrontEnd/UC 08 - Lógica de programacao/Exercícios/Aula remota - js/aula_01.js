const listadepecas = ["Cardan","Oil","Pneu"]
console.log(listadepecas)

// ver se tem 10 pecas ou mais
if (listadepecas.length >= 10) {
    console.log("E Impossivel cadastrar mais pecas")   
} else {
    console.log("E possivel cadastrar mais pecas")
} 
console.log("E possivel cadastrar mais " +((listadepecas.length-10)*-1)+ " pecas.")
console.log("\n")

// ver se a peca tem 100 gramas ou mais 
var peso = [50,120,70] 
if (peso[0] >= 100) { 
    console.log("Peca " +listadepecas[0]+" pode ser cadastrada")
} else {
        console.log("Peso da peca " +listadepecas[0]+ " insuficiente para cadastro")
} 

if (peso[0] >= 100) { 
    console.log("Peca " +listadepecas[1]+" pode ser cadastrada")
} else {
        console.log("Peso da peca " +listadepecas[1]+ " insuficiente para cadastro")
} 

if (peso[0] >= 100) { 
    console.log("Peca " +listadepecas[2]+" pode ser cadastrada")
} else {
        console.log("Peso da peca " +listadepecas[2]+ " insuficiente para cadastro")
} 
console.log("\n")
// checar vetor para cada variavel se o nome tem mais de 3 caracteres
for (let index = 0; index < 3; index++) {
    const element = listadepecas[index];
    if (element.length > 3){
        console.log("A peca " +listadepecas[index]+ " tem o nome apropriado para o cadastro")
    } else {
            console.log(""+listadepecas[index]+ " deve possuir 3 ou mais caracteres para possibilitar o cadastro")
        }
    }
    

