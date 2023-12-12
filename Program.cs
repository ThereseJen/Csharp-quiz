namespace ConsoleApp3
{
    class Program
    {
        //int userPoints = 0; Husk å fikse userpoints til slutt!!!

        static void Main()
        {
            Console.WriteLine("Velkommen! Her kan du velge mellom litt forskjellige aktiviteter.");
            Console.WriteLine("1: Quiz.");
            Console.WriteLine("2: Battle Simulator");

            var userInput = Console.ReadLine();
            Console.Clear();

            
            if (userInput == "1")
            {
                QuizCategories.start();
            }
            else if (userInput == "2")
            {
                BattleSimulator.Start();
            }
            else
            {
                Console.Clear();
            }
        

        }

    }
    }