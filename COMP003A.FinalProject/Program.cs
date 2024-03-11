/*
 * Author: Isaac Cruz
 * Course: COMP003A
 * Purpose: Creating Final Project for COMP003A, 
 */
using System.Net;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(100, '*'));
            Console.WriteLine("Hello, You will need to answer a few questions about yourself before creating a New User Profile for this Dating App.");
            Console.WriteLine("".PadRight(100, '*'));
            Console.WriteLine("\n");

            Console.Write("What is your first name? ");
            string firstname = Console.ReadLine();

            Console.Write("Last name? ");
            string lastname = Console.ReadLine();

            Console.Write("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
            }
            else
            {
                Console.WriteLine("Need to be 18+ to sign up.");
                return;
            }
            int currentYear;
            currentYear = 2023 - age;

            Console.Write("What is your gender? ");
            string gender = Console.ReadLine();
            bool isMale = true;
            bool isFemale = true;
            bool isOther = false;
            if (isFemale || isMale && isOther)
            {
                Console.WriteLine("Gender is Compatible");
            }
            else
            {
                Console.WriteLine("Gender is not compatible.");
                return;
            }
            Console.WriteLine("\n");


            Console.WriteLine("Hello " + firstname + " " + lastname + ", you are currently " + age + " years old. You are also a " + gender + "."); // displays users inputs from previous questions.
            Console.WriteLine("You were born in " + currentYear + "."); // gets the users input and subtracts it from this years date.
            Console.WriteLine("\n");

            Console.WriteLine("".PadRight(100, '*'));
            Console.WriteLine("Congratulations you have successfully answered the few questions about yourself! Now answering a few questions for your profile.");
            Console.WriteLine("".PadRight(100, '*'));
            Console.WriteLine("\n");

            SayQuestions();

            Console.ReadKey();
        }

        static void SayQuestions()
        {
            String[] questions = new string[10];
            String[] answers = new string[10];

            questions[0] = "1. Where do you Live? (ex. City) ";
            questions[1] = "2. How tall are you? (ex. 5' 11) ";
            questions[2] = "3. Weight? (ex. 178lbs) ";
            questions[3] = "4. If you work, What Job do you do? (ex. Job Name) ";
            questions[4] = "5. List Any Hobbies you have: ";
            questions[5] = "6. Race/Ethnicity? (ex. Mexican and/or American) ";
            questions[6] = "7. Life Goals? (ex. Buy a house, get rich) ";
            questions[7] = "8. How many childen do you have? ";
            questions[8] = "9. List 3 places you would like to visit? ";
            questions[9] = "10. Favorite Music Genre? (ex. rap) ";

            for (int q = 0; q < questions.Length; q++)
            {
                Console.WriteLine(questions[q]);
                answers[q] = Console.ReadLine();
                
            }

            Console.WriteLine("The city you live in is " + answers[0] + ". You are " + answers[1] + "feet tall." + " You weigh " + answers[2] + ". Your job is " + answers[3] +". Your hobbies are " + answers[4] + ". Your race and/or ethnicty(s) " + answers[5] + ". Your life goals are " + answers[6] + ". You have " + answers[7] + " kid(s). The 3 places you would like to visit are " + answers[8] + ". To end off, your favorite music genre is " + answers[9] + ". ");


        }

    }
}
