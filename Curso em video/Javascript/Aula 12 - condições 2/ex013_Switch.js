var agora = new Date()
var diaSem = agora.getDay()

switch (diaSem) { // retorna o dia da semana segundo o servidor
    case 0:
        console.log('Domingo')
        break;
    case 1:
        console.log('Segunda')
        break;
    case 2:
        console.log('Terca')
        break;
    case 3:
        console.log('Quarta')
        break;
    case 4:
        console.log('Quinta')
        break;
    case 5:
        console.log('Sexta')
        break;

    default:
        console.log('Sabado')
        break;
}

/*
0 = Domingo
1 = Segunda
2 = Terca
3 = quarta
4 = quinta
5 = sexta
6 = sabado*/