using System;

namespace Atributos_e_Métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            Console.WriteLine("Digite o nome do personagem 1");
            objetoPersonagem1.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do personagem 1");
            objetoPersonagem1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o material da armadura desejada para o personagem 1");
            objetoPersonagem1.armadura = Console.ReadLine();


            Personagem objetoPersonagem2 = new Personagem();

            Console.WriteLine("Digite o nome do personagem 2");
            objetoPersonagem2.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do personagem 2");
            objetoPersonagem2.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o material da armadura desejada para o personagem 2");
            objetoPersonagem2.armadura = Console.ReadLine();


            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()}");
            


        }//FIM Do MAIN
    }
}
