// See https://aka.ms/new-console-template for more information
using rpgTibia.Entities;

Console.WriteLine("digite o nome do personagem");
string nome=Console.ReadLine();
    Character character1 = new Character(nome);
Console.WriteLine("Vocation disponivel\n" +
                          "1-Knight\n" +
                          "2-Paladin\n" +
                          "3-Druid\n" +
                          "4-Sorcerer");

int opcao2 = int.Parse(Console.ReadLine());
string vocation;
if (opcao2 == 1)
{
    vocation = "knight";
    character1.chooseVocation(vocation);
    character1.mostrarStatus();
}
if (opcao2 == 2)
{
    vocation = "Paladin";
    character1.chooseVocation(vocation);
    character1.mostrarStatus();
}
if (opcao2 == 3)
{
    vocation = "Druid";
    character1.chooseVocation(vocation);
    character1.mostrarStatus();
}
if (opcao2 == 4)
{
    vocation = "Sorcerer";
    character1.chooseVocation(vocation);
    character1.mostrarStatus();
}
//Menu principal
character1.listarMenu();