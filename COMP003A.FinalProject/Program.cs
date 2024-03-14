/*
 * Author: Isaac Cruz
 * Course: COMP003A
 * Purpose: Creating Final Project for COMP003A, 
 */

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // greeting the user to create their dating profile
            Console.WriteLine("".PadRight(119, '*'));
            Console.WriteLine("Hello, You will need to answer a few questions about yourself before creating a New User Profile for this Dating App.");
            Console.WriteLine("".PadRight(119, '*'));
            Console.WriteLine("\n");

            Console.Write("What is your first and last name? ");
            string name = Console.ReadLine();
            Console.Write("How old are you? ");
            int ageInput = Convert.ToInt32(Console.ReadLine());
            // checks the users age input if they are able to create an account or not
            if (ageInput >= 18)
            {
                Console.WriteLine("Successful!");
            }
            else if (ageInput < 17)
            {
                Console.WriteLine("Need to be 18+ to sign up.");
                return;
            }
            int currentYear; // subtracts the users age with the current year 
            currentYear = DateTime.Now.Year - ageInput;

            bool isMale = true;
            bool isFemale = true;
            bool isOther = false;

            Console.Write("What is your gender?(M/F/O) ");
            string gender = Console.ReadLine();

            // checks if the user had inserted an appropriate gender to create their profile account
            if (isFemale || isMale)
            {
                Console.WriteLine("Gender is Compatible");
            }
            else if (isOther)
            {
                Console.WriteLine("Gender is not compatible.");
                return;
            }
            Console.WriteLine("\n");

            Console.WriteLine("Hello " + name + ", you are currently " + ageInput + " years old. You are also a " + gender + "."); // displays users inputs from previous questions.
            Console.WriteLine("You were born in " + currentYear + "."); // gets the users input and subtracts it from this years date.
            Console.WriteLine("\n");
            
            Console.WriteLine("".PadRight(119, '*'));
            Console.WriteLine("Congratulations you have successfully answered the few questions about yourself! Now answering a few questions for your profile.");
            Console.WriteLine("".PadRight(119, '*'));
            Console.WriteLine("\n");

            SayQuestions(); // calling the SayQuestions method
            
            /// <summary>
            /// Getting users inputs for age,weight,gender and listing thie information
            /// </summary>
           
           
        }
        /// <summary>
        /// New Method used for asking user questions and getting their answers to be listed back to the user.
        /// </summary>
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

            // questions.Length is used for the amount of questions the loop is going to use
            // q is the variable name for the for loop method
            // q is set to 0 because that is the first number of the amount of questions[] I used
            for (int q = 0; q < questions.Length; q++)
            {
                Console.WriteLine(questions[q]);
                answers[q] = Console.ReadLine();
            }

            // section separator for the end of the dating profile
            Console.WriteLine("".PadRight(150, '*'));
            Console.WriteLine("Congratulations you have successfully created your dating profile account! These are the answers you have provided today. ");
            Console.WriteLine("".PadRight(150, '*'));
            Console.WriteLine("\n");

            // lists the questions the user was given back with their input they had inserted
            Console.WriteLine(questions[0] + answers[0] + ". " + questions[1] + answers[1] + ". " + questions[2] + answers[2] + ". " + questions[3] + answers[3] 
                + ". " + questions[4] + answers[4] + ". " + questions[5] + answers[5] + ". " + questions[6] + answers[6] + ". " + questions[7] + answers[7] 
                + ". " + questions[8] + answers[8] + ". " + questions[9] + answers[9] + ".");



        }

        

    }
}
