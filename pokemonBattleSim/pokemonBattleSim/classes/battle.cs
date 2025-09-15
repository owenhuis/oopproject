using System;

namespace pokemonBattleSim.classes
{
    class Battle
    {
        private Trainer Challenger;
        private Trainer Opponent;

        public Battle(Trainer challenger, Trainer opponent)
        {
            Challenger = challenger;
            Opponent = opponent;
        }
        public void Fight(int ronde_Count)
        {
            bool winner = false;
            while (winner == false)
            {
                Console.WriteLine($"🔥 {Challenger.Name} VS {Opponent.Name}! 🔥");

                Pokemon pokemon1 = Challenger.ThrowPokeball(true, false);
                if (pokemon1 != null)
                {
                    Console.WriteLine($"{pokemon1.Name} komt uit de Pokéball!");
                    Console.WriteLine(pokemon1.BattleCry());
                }
                Pokemon pokemon2 = Opponent.ThrowPokeball(false, true);
                if (pokemon2 != null)
                {
                    Console.WriteLine($"{pokemon2.Name} komt uit de Pokéball!");
                    Console.WriteLine(pokemon2.BattleCry());
                };
                if (winner == false)
                {
                    continue;
                }
                else
                {
                    if (challenger == "defeat")
                    {
                        if (pokemon1 != null) Challenger.ReturnPokemon(pokemon1);
                    }
                    if (opponent == "defeat")
                    {
                        if (pokemon2 != null) Opponent.ReturnPokemon(pokemon2);
                    }
                    
                }
                ronde_Count += 1;
            }
            Console.WriteLine("De strijd is voorbij! 🎉");

        }
    }
}
