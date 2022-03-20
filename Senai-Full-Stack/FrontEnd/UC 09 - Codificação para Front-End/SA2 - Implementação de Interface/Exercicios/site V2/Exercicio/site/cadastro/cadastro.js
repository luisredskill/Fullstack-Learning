/*function login(){
    let email = document.getElementById("emailcadastrado").value
    let senha = document.getElementById("senhacadastrado").value
   
}*/

//contador++;
//$('form').serializeArray()

let emails = []
let senhas = []


function naocadastrado() {

    let naoemail = document.getElementById("naoemailcadastrado").value
    let contador = 0
    let naosenha1 = document.getElementById("naosenhacadastrado").value
    let naosenha2 = document.getElementById("naosenhaconfirmacadastrado").value
    let naocpf = document.getElementById("naocpfcadastrado").value
    let naocep = document.getElementById("naocepcadastrado").value
    let msg = document.getElementById("msg")
    let naosenha1_1 = document.getElementById("naosenha1_1")
    let naosenha2_1 = document.getElementById("naosenha2_1")
    let naocpf1 = document.getElementById("naocpf1")
    let naocep1 = document.getElementById("naocep1")

    if (naosenha1 === naosenha2) {
        if (naocpf.length > 10 && naocpf.length < 15) {
            if (naocep.length == 8) {
                emails.push(naoemail)
                senhas.push(naosenha1)
                msg.innerHTML = "Cadastro efetuado com sucesso"
                msg.style.color = "#03c00d" 

            } else {
                msg.innerHTML = "cep inválido"
                msg.style.color = "#e61b1b8c"
                naocep1.style.background ="#e61b1b8c"
            }
        } else {
            msg.innerHTML = "cpf ou cnpj inválido"
            msg.style.color = "#e61b1b8c"
            naocpf1.style.background ="#e61b1b8c"
        }
    } else {
        msg.innerHTML = "As senhas não coincidem!"
        naosenha1_1.style.background = "#e61b1b8c"
        naosenha2_1.style.background = "#e61b1b8c"
        msg.style.color = "#e61b1b8c"
    }
}

function remRed1() {
    naosenha1_1.style.background = "none"
}

function remRed2() {
    naosenha2_1.style.background = "none"
}

function remRed3() {
    naocpf1.style.background = "none"
}

function remRed4() {
    naocep1.style.background = "none"
}

function login(){
    let email = document.getElementById("emailcadastrado").value
    let senha = document.getElementById("senhacadastrado").value

    if (emails.includes(`${email}`) && senhas.includes(`${senha}`)) {
        alert("login efetuado sucesso")
    } else{
        alert("senha ou email incorretos")
    }
}