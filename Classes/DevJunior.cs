using System;
namespace estudo.Classes
{
	public class DevJunior : Dev
	{
        public DevJunior()
		{
			this.Nivel = "Junior";
		}

        public override void adicionaDev()
        {
            this.TotalDevJr++;
        }
    }
}

