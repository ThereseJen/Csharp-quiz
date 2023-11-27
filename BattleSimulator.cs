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
            Console.WriteLine("");

        }

        private static void StartBattle()
        {

            RagnarFigur helt = new RagnarFigur("Ragnar", 100, 15, 5);
            RolloFigur fiende = new RolloFigur("Rollo", 80, 10, 5);   //Fortsette på denne blant annet

            Console.WriteLine(helt.RagnarIntroduksjon);
            Console.WriteLine(fiende.RolloIntroduksjon);

        }

        //Begynn å lage battle-sekvensen under her. F.eks en while-loop og readline og sånt. IF userinput== "Sloss"  osv.
    }
}
