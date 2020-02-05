using System;

namespace Week4_DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many sides of a dice would you like?");
            int.TryParse(Console.ReadLine(), out int sides);
            do
            {            
                    int roll1 = RollDice(sides);
                    int roll2 = (RollDice(sides));
                    Console.WriteLine("\n"+roll1);
                    Console.WriteLine(roll2);
                if (sides == 6)
                {

                    if(roll1 + roll2 == 2 || roll1 + roll2 == 3 || roll1 + roll2 == 12)
                    {
                        Console.WriteLine("CRAPS!");
                    }

                    if (roll1 + roll2 == 2)
                    {
                        Console.WriteLine("Snake Eyes!");
                    }
                    else if(roll1 == 1 && roll2 == 2 || roll1 == 2 && roll2 == 1)
                    {
                        Console.WriteLine("Ace Deuce!");
                    }
                    else if (roll1 == 6 && roll2 == 6)
                    {
                        Console.WriteLine("Box Cars!");
                    }
                    else if (roll1 + roll2 == 7 || roll1 + roll2 == 11)
                    {
                        Console.WriteLine("WIN!");
                    }

                }
            }
            while (ContinueProgram());



        }

//////////////////////////////////////////////////////////////////////////////////////////////////////
        static bool ContinueProgram()
        {
            char c;
            do
            {
                Console.WriteLine("Press space bar to roll the dice. Other key to fold.");
                c = Console.ReadKey().KeyChar;

                if (c != ' ')
                {
                    Console.WriteLine("\n\nLater. Skater.");
                    Console.ReadLine();
                    return false;
                }

            } while (c !=' ');

            return true;
        }
////////////////////////////////////////////////////////////////////////////////////////////////////

        static int RollDice(int sides)
        {
            Random rndom = new Random();
            int rollDice = rndom.Next(1, sides + 1); 
        
               return rollDice; 
        }




    }
}
