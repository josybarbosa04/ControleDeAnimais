using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Animal animal2 = new Animal();
            Animal animal3 = new Animal();
            Animal animal4 = new Animal();
            Animal animal5 = new Animal();
            int contCachorro = 0, contGato = 0, contPeixe = 0;

            Console.WriteLine("Controle de animais");

            Console.Write("Informe o nome do 1° animal: ");
            animal1.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do 1° animal (Cachorro, Gato ou Peixe): ");
            animal1.Tipo = Console.ReadLine();
            if (animal1.Tipo == "Cachorro") contCachorro++;
            if (animal1.Tipo == "Gato") contGato++;
            if (animal1.Tipo == "Peixe") contPeixe++;
                

            Console.Write("Informe o nome do 2° animal: ");
            animal2.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do 2° animal (Cachorro, Gato ou Peixe): ");
            animal2.Tipo = Console.ReadLine();
            if (animal2.Tipo == "Cachorro") contCachorro++;
            if (animal2.Tipo == "Gato") contGato++;
            if (animal2.Tipo == "Peixe") contPeixe++;

            Console.Write("Informe o nome do 3° animal: ");
            animal3.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do 3° animal (Cachorro, Gato ou Peixe): ");
            animal3.Tipo = Console.ReadLine();
            if (animal3.Tipo == "Cachorro") contCachorro++;
            if (animal3.Tipo == "Gato") contGato++;
            if (animal3.Tipo == "Peixe") contPeixe++;

            Console.Write("Informe o nome do 4° animal: ");
            animal4.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do 4° animal (Cachorro, Gato ou Peixe): ");
            animal4.Tipo = Console.ReadLine();
            if (animal4.Tipo == "Cachorro") contCachorro++;
            if (animal4.Tipo == "Gato") contGato++;
            if (animal4.Tipo == "Peixe") contPeixe++;

            Console.Write("Informe o nome do 5° animal: ");
            animal5.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do 5° animal (Cachorro, Gato ou Peixe): ");
            animal5.Tipo = Console.ReadLine();
            if (animal5.Tipo == "Cachorro") contCachorro++;
            if (animal5.Tipo == "Gato") contGato++;
            if (animal5.Tipo == "Peixe") contPeixe++;

            Console.WriteLine("Total de animais");
            Console.WriteLine("Cachorros: " + contCachorro);
            Console.WriteLine("Gatos: " + contGato);
            Console.WriteLine("Peixes: " + contPeixe);

            Console.ReadKey();
        }
    }
}
