using System;
using System.Media;
using System.Net;
using System.Threading;

namespace pokemonBattleSim.classes
{
    class Battle
    {
        public Trainer Challenger;
        public Trainer Opponent;

        public Battle(Trainer challenger, Trainer opponent)
        {
            Challenger = challenger;
            Opponent = opponent;
        }
        public int Fight(int ronde_Count)
        {
            bool winner = false;
            string player = "start";
            string computer = "start";
            int player_wins = 0;
            int computer_wins = 0;
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
                if (pokemon1 == null || pokemon2 == null)
                {
                    Console.WriteLine("game end");
                     winner = true;
                }
                Thread.Sleep(1000);
                if (pokemon1.Strength == pokemon2.Strength)
                {
                    Console.WriteLine("gelijkspel");

                }
                else if (pokemon1.Strength == pokemon2.Weakness)
                {
                    Console.WriteLine($"{Challenger.Name} wint deze ronde");
                    player = "winner";
                    computer = "defeat";
                }
                else if (pokemon2.Strength == pokemon1.Weakness)
                {
                    Console.WriteLine($"{Opponent.Name} wint deze ronde");
                    player = "defeat";
                    computer = "winner";
                }

                if (player == "defeat")
                {
                    if (pokemon1 != null) Challenger.ReturnPokemon(pokemon1, false);
                    computer_wins++;
                }
                else if (computer == "defeat")
                {
                    if (pokemon2 != null) Opponent.ReturnPokemon(pokemon2, false);
                    player_wins++;
                }
                else { 
                    Challenger.ReturnPokemon(pokemon1, true);
                    Opponent.ReturnPokemon(pokemon2, true);
                }

                
                ronde_Count += 1;
                if (player_wins == 3 || computer_wins == 3)
                {
                    winner = true;
                    break;
                }
            }
            Console.WriteLine("De strijd is voorbij! 🎉");
            return ronde_Count;
        }
    }
}
