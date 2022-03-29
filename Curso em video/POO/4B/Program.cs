using POO.classes;

Console.Clear();

Caneta nc = new Caneta("BIC","Azul", 0.5f);

//c.modelo = "BIC"; privado
//nc.setModelo("BIC");

//nc.ponta = 0.5f; privado
//nc.setPonta(1f);

Console.WriteLine($"Tenho uma caneta {nc.getModelo()}");
Console.WriteLine($"Ela tem uma ponta de {nc.getPonta()} ");
Console.WriteLine($"Ela tem a cor {nc.getCor()}");




