using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {

        bool blr = true;

        while(blr == true) {
        
            Random randomGenerator = new Random();
            int mn = randomGenerator.Next(1, 101);

            bool loopRunner = true;

            int gc = 1;

            while(loopRunner == true) {

                Console.Write("What is your guess: ");
                int g = int.Parse(Console.ReadLine());

                if(g == mn) {
                    loopRunner = false;
                } else if(g > mn) {
                    Console.WriteLine("Lower");
                    gc++;
                } else if(g < mn) {
                    Console.WriteLine("Higher");
                    gc++;
                } 

            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Guess Count: {gc}\n");
            Console.Write("Do you want to play again: ");
            string response = Console.ReadLine();

            Console.WriteLine("");

            if(response != "yes") {
                blr = false;
            }

        }

    }
}