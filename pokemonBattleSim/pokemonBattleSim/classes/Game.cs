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
                Charmander charmander1 = Challenger.ThrowPokeball();
                if (charmander1 != null)
                {
                    Console.WriteLine($"{charmander1.Name} komt uit de Pokéball!");
                    Console.WriteLine(charmander1.BattleCry());
                }

                Charmander charmander2 = Opponent.ThrowPokeball();
                if (charmander2 != null)
                {
                    Console.WriteLine($"{charmander2.Name} komt uit de Pokéball!");
                    Console.WriteLine(charmander2.BattleCry());
                }

                if (charmander1 != null) Challenger.ReturnPokemon(charmander1);
                if (charmander2 != null) Opponent.ReturnPokemon(charmander2);
            }

            Console.WriteLine("De strijd is voorbij! 🎉");
        }
    }
}
