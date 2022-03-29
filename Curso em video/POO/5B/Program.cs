using B.classes;

Console.Clear();
ContaBanco nc = new ContaBanco(1,"cc","Luis");

nc.setStatus(false);

nc.pagarMensalidade();