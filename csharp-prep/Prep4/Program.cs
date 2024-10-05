using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        
        bool loopRunner = true;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        while(loopRunner) {

            Console.Write("Enter number: ");

            int response = int.Parse(Console.ReadLine());

            if(response == 0) {
                loopRunner = false;
            } else {
                numbers.Add(response);
            }

            
            


        }

        Console.Write("The sum is: ");
        int sum = 0;
        foreach(int n in numbers) {
            sum += n;
        }

        Console.WriteLine(sum);

        Console.Write("The average is: ");
        float average = ((float)sum) / numbers.Count();
        Console.WriteLine(average);

        Console.Write("The largest number is: ");
        int x = 0;
        foreach(int i in numbers) {
            if(i > x) {
                x = i;
            }

        }
        Console.WriteLine(x);

    }
}