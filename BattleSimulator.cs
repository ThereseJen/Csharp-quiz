using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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

                var userInput = Console.ReadLine();

         while (helt.Liv > 0 && fiende.Liv > 0)  //While-løkke for at spillet skal fortsette helt til en er beseiret. 
            {
                Console.WriteLine($"Din helse er {helt.Liv}");
                Console.WriteLine($"Rollo sin helse er {fiende.Liv}.");
                Console.WriteLine("Trykk Enter for å starte kampen!");
                Console.Clear();

                Console.WriteLine("1. Angrip med øks.");




            }
         
        }

                    
        
    }
}
