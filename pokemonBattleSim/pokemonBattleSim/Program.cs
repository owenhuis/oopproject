using System;
using pokemonBattleSim.classes;

namespace pokemonBattleSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij Pokémon Battle Sim!");

            Trainer trainer1 = CreateTrainer(1);
            Trainer trainer2 = CreateTrainer(2);


            Game game = new Game(trainer1, trainer2);
            game.Fight();
        }

        static Trainer CreateTrainer(int number)
        {
            Console.Write($"Voer de naam in van trainer {number}: ");
            string name = Console.ReadLine();
            return new Trainer(name);
        }
        
    }
}
