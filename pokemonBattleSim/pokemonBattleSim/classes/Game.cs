using System;

namespace pokemonBattleSim.classes
{
    class Game
    {
        private Trainer Challenger;
        private Trainer Opponent;

        public Game(Trainer challenger, Trainer opponent)
        {
            Challenger = challenger;
            Opponent = opponent;
        }
        public void Fight()
        {
            Console.WriteLine($"🔥 {Challenger.Name} VS {Opponent.Name}! 🔥");

            for (int i = 0; i < 6; i++) // Aantal Pokéballs per trainer
            {
                Pokemon pokemon1 = Challenger.ThrowPokeball();
                if (pokemon1 != null)
                {
                    Console.WriteLine($"{pokemon1.Name} komt uit de Pokéball!");
                    Console.WriteLine(pokemon1.BattleCry());
                }
                Pokemon pokemon2 = Opponent.ThrowPokeball();
                if (pokemon2 != null)
                {
                    Console.WriteLine($"{pokemon2.Name} komt uit de Pokéball!");
                    Console.WriteLine(pokemon2.BattleCry());
                }
                if (pokemon1 != null) Challenger.ReturnPokemon(pokemon1);
                if (pokemon2 != null) Opponent.ReturnPokemon(pokemon2);
            }
            Console.WriteLine("De strijd is voorbij! 🎉");
            
        }
    }
}
