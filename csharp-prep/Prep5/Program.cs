using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // CSE 210
        // Anna Burke
        // Function Practice

        // Look I was procrastinating HARD on this assignment until I decided to make it a little
        // story! The Gambling Guy is a character I made up for other programming projects and 
        // he just does whatever. I hope it's ok that I added him in! It still does the same 
        // thing just with more words.

        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squareNumber, birthYear);
    }    

        static void DisplayWelcome()
        {
            Console.WriteLine("..Where am I? This doesn't look like anywhere I've been before...");
            Console.WriteLine("Whatever. Welcome to the program in a hell of my own making. I'm the Gambling Guy, and I'm not sure what happens next.");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Sorry, I forgot to ask. What was your name?");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("That's a cool name. Yaknow, since I'm the Gambling Guy and all, what's your favorite number? Like on cards. Uh, it can be higher than 13 if you want.");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static void PromptUserBirthYear(out int birthYear)
        {
            Console.WriteLine("I've never thought about that number being anyone's favorite... whatever. Another question -- what year were you born?");
            birthYear = int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int number)
        {
            number *= number;
            return number;
        }

        static void DisplayResult(string name, int number, int birthYear)
        {
            Console.WriteLine($"Yaknow, {name}, I have a friend who's really good at math. His name's the Math Man. He taught me a thing or two, so I know that your favorite number squared is {number}. Cool, right?");
            Console.WriteLine($"Oh, and since you were born in {birthYear}, you'd turn {2025 - birthYear} years old this year. huh. That's pretty old. When was I born? I don't remember. I feel like it was a year ago, but that can't be right. I mean, I feel like an adult. this is all too strange...");
        }


    
}