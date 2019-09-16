using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName;
            string theActivity;
            int numberOfPeople;

            Console.WriteLine("Hello, what is your name?");
            firstName = Console.ReadLine();
            Console.WriteLine("Hello {0}, out of the 4 options listed below, please pick the one activity you would like to do today!", firstName);
            Console.WriteLine("1. Action");
            Console.WriteLine("2. Chilling");
            Console.WriteLine("3. Danger");
            Console.WriteLine("4. Good Food");
            Console.WriteLine("For example: If you would like Good Food select option '4'");
            //Choose one activity
            theActivity = Console.ReadLine();
            // Choose number of people
            Console.WriteLine("Nice, how many people do you plan on bringing?");
            numberOfPeople = Convert.ToInt32(Console.ReadLine());
            //option1
            if (theActivity == "1")
            {
                if (numberOfPeople == 0)
                {
                    Console.WriteLine("If youre in the mood for action then you should go stock car racing and travel by sneakers.");
                }
                else if (numberOfPeople > 0 && numberOfPeople <= 4)
                {
                    Console.WriteLine("If youre in the mood for action then you should go stock car racing and travel in a sedan.");
                }
                else if (numberOfPeople > 5 && numberOfPeople <= 10)
                {
                    Console.WriteLine("If youre in the mood for action then you should go stock car racing and travel in a volkswagon bus.");
                }
                else
                {
                    Console.WriteLine("If youre in the mood for action then you should go stock car racing and travel in an airplane.");
                }
            }
            //option2
            else if (theActivity == "2")
            {
                if (numberOfPeople == 0)
                {
                    Console.WriteLine("If youre in the mood for chilling then you should go hiking and travel by sneakers.");
                }
                else if (numberOfPeople > 0 && numberOfPeople <= 4)
                {
                    Console.WriteLine("If youre in the mood for chilling then you should go hiking and travel in a sedan.");
                }
                else if (numberOfPeople > 5 && numberOfPeople <= 10)
                {
                    Console.WriteLine("If youre in the mood for chilling then you should go hiking and travel in a volkswagon bus.");
                }
                else
                {
                    Console.WriteLine("If youre in the mood for chilling then you should go hiking and travel in an airplane.");
                }
            }
            //option3
            else if (theActivity == "3")
            {
                if (numberOfPeople == 0)
                {
                    Console.WriteLine("If youre in the mood for danger then you should go skydiving and travel by sneakers.");
                }
                else if (numberOfPeople > 0 && numberOfPeople <= 4)
                {
                    Console.WriteLine("If youre in the mood for danger then you should go skydiving and travel in a sedan.");
                }
                else if (numberOfPeople > 5 && numberOfPeople <= 10)
                {
                    Console.WriteLine("If youre in the mood for danger then you should go skydiving and travel in a volkswagon bus.");
                }
                else
                {
                    Console.WriteLine("If youre in the mood for danger then you should go skydiving and travel in an airplane.");
                }
            }
            //option4
            else
            {
                if (numberOfPeople == 0)
                {
                    Console.WriteLine("If youre in the mood for good food then you should go to Taco Bell and travel by sneakers.");
                }
                else if (numberOfPeople > 0 && numberOfPeople <= 4)
                {
                    Console.WriteLine("If youre in the mood for good food then you should go to Taco Bell and travel in a sedan.");
                }
                else if (numberOfPeople > 5 && numberOfPeople <= 10)
                {
                    Console.WriteLine("If youre in the mood for good food then you should go to Taco Bell and travel in a volkswagon bus.");
                }
                else
                {
                    Console.WriteLine("If youre in the mood for good food then you should go to Taco Bell and travel in an airplane.");
                }
            }
            Console.WriteLine("Goodbye!");
        }
    }
}