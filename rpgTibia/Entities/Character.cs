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
        // abrir o menu aqui eu fassa o loop do menu
        public void abrimenu()
        {
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 0)
            {
                
                if (opcao == 1)
                {
                    vocation.calcularlevel();
                    vocation.setMp(vocation.calcularAtualMp());
                    vocation.setHp(vocation.calcularAtualHp());
                    mostrarStatus();
                }
                if (opcao == 2)
                {
                    mostrarStatus(); // Exibe o status
                }

                // Pergunta novamente pela opção para não criar um loop infinito
                Console.WriteLine("---------------------Menu-------------------\n" +
                               "1-Aumentar Level\n" +
                               "2-Listar Status\n" +
                               "0-Sair\n");
                opcao = int.Parse(Console.ReadLine());  // Atualiza a variável 'opcao'
            }

            Console.WriteLine("Menu fechado.");
        }
        //aqui eo menu oficial
        public void listarMenu()
        {
            Console.WriteLine("---------------------Menu-------------------\n" +
                                "1-Aumentar Level\n" +
                                "2-Listar Status\n" +
                                "0-Sair\n");

            abrimenu();  // Chama a função que exibe o menu e lida com as opções
        }

        //aqui e a opção que eu posso escolher  a minha vocation
        public void chooseVocation(String vocation)
        {
            if (vocation == "knight")
            {
                Console.WriteLine("O char " + this.name + " agora é um Knight!");
                nameVocation = "Knight";
                this.vocation = new Knight();
            }
            if (vocation == "Paladin")
            {
                Console.WriteLine("O char " + this.name + " agora é um Paladin!");
                nameVocation = "Paladin";
                this.vocation = new Paladin();
            }
            if (vocation == "Druid")
            {
                Console.WriteLine("O char " + this.name + " agora é um Druid!");
                nameVocation = "Druid";
                this.vocation = new Druid();
            }
            if (vocation == "Sorcerer")
            {
                Console.WriteLine("O char " + this.name + " agora é um Sorcerer!");
                nameVocation = "Sorcerer";
                this.vocation = new Sorcerer();
            }
        }


        // aqui eu busco o meu nome
        public String getName()
        {
            return name;
        }
        // aqui eu mostro o meu status
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
