using System;
namespace estudo.Classes
{
    public class DevPleno : Dev
    {
        public DevPleno()
        {
            this.Nivel = "Pleno";
        }

        public override void adicionaDev()
        {
            this.TotalDevPl++;
        }
    }
}

