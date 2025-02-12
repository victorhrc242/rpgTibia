using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgTibia.Entities
{
    internal class Character
    {
        public Character(String name)
        {
            this.name = name;
            this.vocation = new Vocation();
            vocation.setMp(vocation.calcularAtualMp());
            vocation.setHp(vocation.calcularAtualHp());
        }

        private String name;
        private Vocation vocation;
        private String nameVocation = "No Vocation";

        public void chooseVocation(String vocation)
        {
            if (vocation == "knight")
            {
                Console.WriteLine("O char " + this.name + " agora é um Knight!");
                nameVocation = "Knight";
                this.vocation = new Knight();
            }


        }

        public String getName()
        {
            return name;
        }

        public void mostrarStatus()
        {
            Console.WriteLine("Char: " + name);
            Console.WriteLine("Vocação: " + nameVocation);
            Console.WriteLine("Level: " + vocation.getLevel());
            Console.WriteLine("HP: " + vocation.getHp() + " / MP: " + vocation.getMp());

        }

        public void atacar()
        {

        }

        public void curar()
        {

        }



    }
}
