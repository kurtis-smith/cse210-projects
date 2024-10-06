using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();

        string username = PromptUserName();
        int number = PromptUserNumber();

        int squaredNumber = squareNumber(number);

        DisplayResult(username, squaredNumber);

    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();

        return username;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squareNumber(int number) {
        int squaredNumber = number * number;
        
        return squaredNumber;
    }

    static void DisplayResult(string username, int squaredNumber) {

        Console.WriteLine($"{username}, the square of your number is {squaredNumber}");

    }
    
}