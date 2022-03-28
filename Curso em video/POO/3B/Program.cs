using POO.classes; // marcação que diz que estou usando as classes da pasta classes

Caneta nc = new Caneta(); // nova caneta, criação de um objeto do tipo caneta

nc.cor = "zul"; //atributos da nova caneta nc
nc.ponta = 0.5f;
nc.tampado = true;
nc.modelo = " Minha Caneta";
nc.carga = 50;

Console.Clear();
nc.status(); // chama o metodo que mostra os atributos da nova caneta nc
nc.rabiscar();

Caneta nc2 = new Caneta(); // nova caneta 2 nc2

nc2.modelo = "Luis";
nc2.cor = "Preta";
nc2.destampar();
nc2.status();
nc2.rabiscar();
