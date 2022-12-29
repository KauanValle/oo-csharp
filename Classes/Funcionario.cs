using System;

namespace estudo.Classes
{
	public abstract class Funcionario
	{
		private string nome;
        private string cpf;
        private double salario;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public void showAll()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Cpf: " + this.cpf);
            Console.WriteLine("Salario: " + this.salario);
            Console.WriteLine("------------------");
        }
    }
}

