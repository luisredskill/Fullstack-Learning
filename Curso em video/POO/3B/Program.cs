using POO.classes; // marcação que diz que estou usando as classes da pasta classes

Console.Clear();

Caneta nc = new Caneta(); // nova caneta, criação de um objeto do tipo caneta

Console.Clear();
nc.modelo = "bic cristal";
nc.cor = "Azul";
//nc.ponta = 0.5; atributo privado
//nc.carga = 80; atributo protegido
nc.destampar();
nc.Tampar();
nc.status();
