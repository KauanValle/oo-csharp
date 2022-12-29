using System;
namespace estudo.Classes
{
	public class DevSenior : Dev
	{
		public DevSenior()
		{
			this.Nivel = "Senior";
		}

        public override void adicionaDev()
        {
			this.TotalDevSr++;
        }
    }
}

