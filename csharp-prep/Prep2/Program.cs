using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");

        int grade = int.Parse(Console.ReadLine());

        string letterGrade = "";

        if (grade >= 90) {
            int local = 90;
            string localLetter = "A";
            if (grade - local < 3) {
                letterGrade = $"{localLetter}-";
            } else {
                letterGrade = localLetter;
            }
        } else if (grade >= 80) {
            int local = 80;
            string localLetter = "B";
            if (grade - local >= 7) {
                letterGrade = $"{localLetter}+";
            } else if (grade - local < 3) {
                letterGrade = $"{localLetter}-";
            } else {
                letterGrade = localLetter;
            }
        } else if (grade >= 70) {
            int local = 70;
            string localLetter = "C";
            if (grade - local >= 7) {
                letterGrade = $"{localLetter}+";
            } else if (grade - local < 3) {
                letterGrade = $"{localLetter}-";
            } else {
                letterGrade = localLetter;
            }
        } else if (grade >= 60) {
            int local = 60;
            string localLetter = "D";
            if (grade - local >= 7) {
                letterGrade = $"{localLetter}+";
            } else if (grade - local < 3) {
                letterGrade = $"{localLetter}-";
            } else {
                letterGrade = localLetter;
            }
        } else if (grade < 60) {
            letterGrade = "F";
        }

        Console.WriteLine($"Letter Grade: {letterGrade}");

        if (grade >= 70) {
            Console.WriteLine("You passed the course!");
        } else {
            Console.WriteLine("You did NOT pass the course!");
        }

    }
}