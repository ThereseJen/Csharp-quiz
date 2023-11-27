
namespace ConsoleApp3
{
    internal class QuizCategories
    {

        public static void start()
        {
            Console.WriteLine("Er du klar for Quiz?");
            var userInput = Console.ReadLine();

            Console.WriteLine("\n");

            if (userInput.ToLower() == "ja")
            {
                Console.WriteLine($"Du har svart {userInput}. Da kjører vi på med litt hovedstader!");
                Console.WriteLine("Trykk Enter for å fortsette!");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"Quizen starter uansett.");
            }

            SpillQuiz();


        }

        private static void SpillQuiz()
        {
            Console.WriteLine("\n");
            Spørsmål("Hva er hovedstaden i Norge?", "Oslo");
            Spørsmål("Hva er hovedstaden i Frankrike?", "Paris");
            Spørsmål("Hva er hovedstaden på Island?", "Reykjavik");
            Spørsmål("Hva er hovedstaden i Spania?", "Madrid");

            Console.WriteLine("\n");
            Console.WriteLine("Kategori 1 ferdig, trykk enter.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Det var ganske lett, var det ikke? La oss bytte katergori til....dyr!");
            Console.WriteLine("Trykk enter hvis du takler utfordringen.");
            Console.ReadLine();
            Console.Clear();

            Spørsmål("Hva er det største dyret i verden?", "Blåhval");
            Spørsmål("Hva er det eneste pattedyret som kan fly?", "Flaggermus");
            Spørsmål("Hvilket dyr er kjent for å vende maten sin opp-ned før de spiser det?", "Flodhest");
            Spørsmål("Hva er den raskeste fuglen i verden?", "Vandrefalk");

            Console.WriteLine("\n");
            Console.WriteLine("Da var den kategorien ferdig. Skal vi ta litt blanda drops til slutt?");
            Console.WriteLine("Trykk Enter.");
            Console.ReadLine();
            Console.Clear();

            Spørsmål("Hva er hovedbestanddelen i guacamole?", "Avocado");
            Spørsmål("Hvilken planet er kjent som \"kveldsstjernen\" eller \"morgenstjernen\"?", "Venus");
            Spørsmål("Hvem skrev skuespillet \"Romeo og Julie\"?", "William Shakespeare");
            Spørsmål("Hvilket britisk rockeband er kjent for albumet \"The Dark Side of the Moon\"?", "Pink Floyd");

            Console.WriteLine("\n");
            Console.WriteLine("Da var quizzen ferdig.");
            Console.WriteLine("Trykk Enter.");
            Console.ReadLine();
            Console.Clear();

          //  Console.WriteLine($"Du hadde {userPoints} rette svar.");


        }

        static void Spørsmål(string Spørsmål, string Riktigsvar)
        {

            Console.WriteLine(Spørsmål);
            string svar = Console.ReadLine();

            if (svar.ToLower() == Riktigsvar.ToLower())
            {
                Console.WriteLine("Svaret er riktig!");
             //   userPoints++;
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine($"Svaret er feil. Riktig svar er {Riktigsvar}.");
                Console.WriteLine("\n");
            }

        }

    }
}
