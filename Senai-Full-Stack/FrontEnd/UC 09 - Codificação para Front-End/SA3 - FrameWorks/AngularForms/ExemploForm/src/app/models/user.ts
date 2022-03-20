export class User {
    //metodo constructor(){}, controi um modelo para salvar as informacoes do usuario
    constructor(
        public email: string, // o typescript necessita saber do tipo da variavel
        public senha: string // public significa que essa variavel pode ser acessada de qualquer lugar do projeto

    ) {

    }
    
}
