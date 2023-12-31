﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class RagnarFigur
    {
        public string Navn;
        public int Liv;
        public int Skjold;
        public int Mat;

        public RagnarFigur(string navn, int liv, int skjold, int mat)
        {
            Navn = navn;
            Liv = liv;
            Skjold = skjold;
            Mat = mat;
        }

        public void RagnarAnsikt()
        {

        }

        public string RagnarIntroduksjon()
        {
            return $"Karakteren du skal spille med, er {Navn}.\n" +
                   $"Du starter med {Liv} i helse, altså fullt. \n"    +
                   $"{Navn} har også et skjold, det gir deg {Skjold} i beskyttelse. \n" +
                   $"Du har litt mat med deg i ryggsekken. Den gir deg {Mat} ekstra på helsa.";
        }

        public void useShield()
        {
            int shield = new Random().Next(10, 26);
            Liv += shield;
            Console.WriteLine($"{Navn} brukte skjoldet sitt og helte {shield} i helse!");
        }

        public void useFood()
        {
            int food = new Random().Next(10, 16);
            Liv += food;
            Console.WriteLine($"{Navn} spiste mat og fikk {food} mer i helse!");
        }
    }
}
