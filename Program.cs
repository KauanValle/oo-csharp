using estudo.Classes;

Gerente gerente = new Gerente();
gerente.Nome = "Kauan";
gerente.Cpf = "08019113975";
gerente.Salario = 5000;

Gerente gerente2 = new Gerente();
gerente2.Nome = "Kimberli";
gerente2.Cpf = "11111111111";
gerente2.Salario = 6000;

//DevJunior devJr1 = new DevJunior();
//devJr1.Stack = "Back-end, PHP, Laravel, Java e C#";
//gerente.cadastrarDev(devJr1);

//DevJunior devJr2 = new DevJunior();
//devJr2.Stack = "Back-end, PHP, Laravel, Java e C#";
//gerente.cadastrarDev(devJr2);

//DevPleno devPl1 = new DevPleno();
//devPl1.Stack = "Back-end, PHP, Laravel, Java e C#";
//gerente.cadastrarDev(devPl1);

//DevPleno devPl2 = new DevPleno();
//devPl2.Stack = "Back-end, PHP, Laravel, Java e C#";
//gerente.cadastrarDev(devPl2);

//DevPleno devPl3 = new DevPleno();
//devPl3.Stack = "Back-end, PHP, Laravel, Java e C#";
//gerente.cadastrarDev(devPl3);

//DevPleno devPl4 = new DevPleno();
//devPl4.Stack = "Back-end, PHP, Laravel, Java e C#";
//gerente.cadastrarDev(devPl4);

//DevSenior devSr1 = new DevSenior();
//devSr1.Stack = "Back-end, PHP, Laravel, Java e C#";
//gerente.cadastrarDev(devSr1);

//DevSenior devSr2 = new DevSenior();
//devSr1.Stack = "Back-end, PHP, Laravel, Java e C#";
//gerente.cadastrarDev(devSr2);

gerente.gerarAutomaticamente(2,10,3);

Console.WriteLine("Total de gerentes cadastrados: " + Gerente.TotalDeGerentes);
Console.WriteLine("Total de DevJR cadastrados: " + gerente.TotalDevJr + " do gerente " + gerente.Nome);
Console.WriteLine("Total de DevPL cadastrados: " + gerente.TotalDevPl + " do gerente " + gerente.Nome);
Console.WriteLine("Total de DevSR cadastrados: " + gerente.TotalDevSr + " do gerente " + gerente.Nome);