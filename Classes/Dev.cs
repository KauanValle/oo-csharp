using System;
namespace estudo.Classes
{
	public abstract class Dev : Funcionario
	{
		private string stack;
		private string nivel;
        private int totalDevJr;
        private int totalDevPl;
        private int totalDevSr;

        public string Nivel {
			get => nivel; set => nivel = value;
		}

        public string Stack {
			get => stack; set => stack = value;
		}

        public int TotalDevJr
        {
			get => totalDevJr; set => totalDevJr = value;
		}

        public int TotalDevPl {
            get => totalDevPl; set => totalDevPl = value;
        }

        public int TotalDevSr {
            get => totalDevSr; set => totalDevSr = value;
        }

        public abstract void adicionaDev();
    }
}

