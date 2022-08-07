using System;
using System.Threading;

namespace SelectionStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // this includes excerise 1 and 2. 
  
            Console.WriteLine("ITS TIME TO PLAY...GUESS THAT NUMBER !!!!! WOOT WOOT");
            Thread.Sleep(1000);

            Console.WriteLine("Lucky contestent , Let's see if you can guess the correct number.");
            Thread.Sleep(1000);
            Console.WriteLine("What is the upper limit for us to guess from, Must be no higher then 10.");

            var userResponse = (Console.ReadLine());

            var upperLimit = int.Parse((userResponse));

            var random = new Random();
            var number = random.Next(1,upperLimit);

            int guess;
            do
            {
                Console.WriteLine("So Contestent, what shall be your guess?");

                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Your Guess is too High! Sorry");

                }
                else if (guess < number)
                {
                    Console.WriteLine("Your Guess is too Low! Sorry");

                }
                else
                {
                    Console.WriteLine("Correct, You Did it!");
                }
            } while (guess != number);

            Console.WriteLine("What is your favorite subject in school");

            var subject = Console.ReadLine();  // basically a string

            switch (subject.ToLower())  // you use this tool to not have to write lines for Lower and upper case
            {
                case "math":
                    Console.WriteLine("I like Math as well.");
                    break;
                case "science":
                    Console.WriteLine("Science, that is so cool.");
                    break;
                case "english":
                    Console.WriteLine("I dont like English, but hey you do.");
                    break;
                default:
                    Console.WriteLine($"Oh, I didn't see that coming. {subject} sounds interesting.");
                    break;
            }


            
        }
    }
}

