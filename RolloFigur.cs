using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class RolloFigur
    {
        public string Navn;
        public int Liv;
        public int Skjold;
        public int Mat;

        public RolloFigur(string navn, int liv, int skjold, int mat)
        {
            Navn = navn;
            Liv = liv;
            Skjold = skjold;
            Mat = mat;
        }

        public string RolloIntroduksjon()
        {
       return $"Den du skal spille mot, er {Navn}.\n" +
       $"Han starter med {Liv} i helse. \n" +
       $"{Navn} har også et skjold, det gir deg {Skjold} i beskyttelse. \n" +
       $"Han har med litt mat i ryggsekken. Den gir han {Mat} ekstra på helsa.";

        }

        public void useShield()
        {
            int shield = new Random().Next(10, 21);
            Liv += shield;
            Console.WriteLine($"{Navn} brukte skjoldet sitt og helte {shield} i helse!")
        }

        public void useFood()
        {
            int food = new Random().Next(10, 11);
            Liv += food;
            Console.WriteLine($"{Navn} spiste mat og fikk {food} mer i helse!")
        }
    }
}
