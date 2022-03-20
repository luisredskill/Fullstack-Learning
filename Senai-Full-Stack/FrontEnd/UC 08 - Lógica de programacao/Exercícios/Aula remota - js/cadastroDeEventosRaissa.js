// Programa para cadastro de evento - Atividade Online 2 - UC8

let idadeParticipante, listaParticipantes;
let dataAtual = new Date();


//--------------------------------------------------------------------------------------
// Neste programa não será usada a requisição dados por meio do terminal
// As variáveis serão declaradas simulando as respostas do usuário
//--------------------------------------------------------------------------------------

console.log("\n");
// Pergunta ao usuário a data do evento e armazena em variáveis
//console.log("Seja bem vindo! Digite o dia que ocorrerá o seu evento: (apenas números)");
let cadastroDiaEvento = 31;

//console.log("Digite o mês que ocorrerá o seu evento: (apenas números)");
let cadastroMesEvento = 08;

//console.log("Digite o ano que ocorrerá o seu evento: (apenas números. 4 dígitos)");
let cadastroAnoEvento = 2021;

//--------------------------------------------------------------------------------------
// Teste para saber se a data informada é igual ou posterior a data atual

if(cadastroAnoEvento > dataAtual.getFullYear()){
    console.log("Data permitida! Cadastro realizado com sucesso!");
    //console.log("ano ok");
} else if((cadastroMesEvento > (dataAtual.getMonth() + 1)) & (cadastroAnoEvento >= dataAtual.getFullYear()) ){
    console.log("Data permitida! Cadastro realizado com sucesso!");
    //console.log("mes ok");
} else if((cadastroDiaEvento > dataAtual.getDate()) & (cadastroMesEvento >= (dataAtual.getMonth() + 1)) & (cadastroAnoEvento >= dataAtual.getFullYear())){
    console.log("Data permitida! Cadastro realizado com sucesso!");
    //console.log("dia ok");
} else {
    console.log("Falha no cadastro. A data informada deve ser posterior a data inicial!");
}

//--------------------------------------------------------------------------------------
//Registro de Participantes e verificação da idade

console.log("\n");
//console.log("\nCadastro de participante. Digite o nome do participante: ");

listaParticipantes = ["Maria", "Joao", "Raul", "Pedro"];

//console.log("Digite a idade do participante: ");
idadeParticipante = [15, 20, 34, 18];

let participantesCadastrados = new Array(); 

if(listaParticipantes.length < 100){
    for (let i = 0; i < listaParticipantes.length; i++) {
        if((idadeParticipante[i] < 18)){
            console.log("Erro no cadastro. O participante não pode ter menor que 18 anos!");
            
        } else{
            console.log("O participante " + listaParticipantes[i] + " foi cadastrado com sucesso!");
            participantesCadastrados.push(listaParticipantes[i]); 
        }
    }  
} else {
    console.log("Limite de participantes atingido. Não é possível cadastrar mais nenhum participante!");
}

//console.log(participantesCadastrados);

//--------------------------------------------------------------------------------------
//Listar participantes cadastrados

console.log("\nParticipantes cadastrados:");

for (let i = 0; i < participantesCadastrados.length; i++) {
    console.log("Participante "+ (i+1) + ": " + participantesCadastrados[i]);
}  