using System;
namespace estudo.Classes
{
	public class Gerente : Funcionario
	{
		private static int totalDeGerentes;
		private static int totalDeFuncionarios;
        private static int totalDeDev;

		private int totalDevJr;
        private int totalDevPl;
        private int totalDevSr;


        public static int TotalDeGerentes
		{
			get { return totalDeGerentes; }
			set { totalDeGerentes = value; }
		}

        public int TotalDevJr { get => totalDevJr; set => totalDevJr = value; }
        public int TotalDevPl { get => totalDevPl; set => totalDevPl = value; }
        public int TotalDevSr { get => totalDevSr; set => totalDevSr = value; }

        public Gerente()
		{
			totalDeGerentes++;
		}

		public void cadastrarFuncionario()
		{
			totalDeFuncionarios++;
		}

		public void cadastrarDev(Dev dev)
		{
			totalDeFuncionarios++;
			totalDeDev++;
			dev.adicionaDev();

			totalDevJr += dev.TotalDevJr;
            totalDevPl += dev.TotalDevPl;
            totalDevSr += dev.TotalDevSr;
        }

		public void gerarAutomaticamente(int qntDevJr, int qntDevPl, int qntDevSr)
		{
			string stacks = "Php,Java,C#,Html,Css,Javascript,C,C++,Ruby,Python,GoLang,Cobol,Aws,Docker";
			string[] stacksArray = stacks.Split(',');

            Random r = new Random();

            for (int i = 0; i < qntDevJr; i++)
			{
				int numeroRandom = r.Next(0, stacksArray.Length);

                DevJunior devJr = new DevJunior();
				devJr.Stack = stacksArray[numeroRandom];
				this.cadastrarDev(devJr);
            }

			for (int i = 0; i < qntDevPl; i++)
			{
                int numeroRandom = r.Next(0, stacksArray.Length);

                DevPleno devPl = new DevPleno();
                devPl.Stack = stacksArray[numeroRandom];
                this.cadastrarDev(devPl);
            }

			for (int i = 0; i < qntDevSr; i++)
			{
                int numeroRandom = r.Next(0, stacksArray.Length);

                DevSenior devSr = new DevSenior();
                devSr.Stack = stacksArray[numeroRandom];
                this.cadastrarDev(devSr);
            }
		}
    }
}

