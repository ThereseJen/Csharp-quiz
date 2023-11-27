using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class BattleSimulator
    {

        public static void Start()
        {
            Console.WriteLine("Dette er en battle-simulator");
            Console.WriteLine("Er du klar til å starte? (Ja/Nei.)");
            var userInput = Console.ReadLine();

            if (userInput.ToLower() == "ja")
            {
                StartBattle();
            }
            else
            {
                Console.WriteLine("Hva gjør du her da?");
            }

        }

        private static void StartBattle()
        {

            RagnarFigur helt = new RagnarFigur("Ragnar", 100, 15, 5);
            RolloFigur fiende = new RolloFigur("Rollo", 80, 10, 5);  // instanser

            Console.WriteLine(helt.RagnarIntroduksjon());
            Console.WriteLine("\n");
            Console.WriteLine(fiende.RolloIntroduksjon());
            Console.WriteLine("\n");
            Console.WriteLine("Trykk \"enter\" når du har lest!");
            Console.ReadLine();
            Console.Clear();

        }



        private static void Attack(RagnarFigur attacker, RolloFigur enemy)
        {
            int damage = new Random().Next(5, 16);      //Genererer random skade mellom 5 og 15.
            Console.WriteLine($"{attacker.Navn} angriper {enemy.Navn}, og gjør {damage} skade.");

         enemy.Liv -= damage;

            if (enemy.Liv <= 0)
            {
                Console.WriteLine($"{enemy.Navn} er beseiret!");
            }

            attacker.Liv -= damage;

            if (attacker.Liv <= 0)
            {
                Console.WriteLine($"{attacker.Navn} er død. GAME OVER.");
            }
                    
        }
    }
}
