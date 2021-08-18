using System;

namespace CTU_Vaccine_Development
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type your details and press enter
            Console.WriteLine("Enter your ID");
            Console.WriteLine("Enter your Surname");
            Console.WriteLine("Enter your First Name");
            Console.WriteLine("Enter Gender");
            Console.WriteLine("Enter your Date of Birth");
            Console.WriteLine("Enter the province");

            // Create a string variable and get user input from the keyboard and store it in the variable
            int ID = Convert.ToInt32(Console.ReadLine());
            string SurN = Console.ReadLine();
            string FirstName = Console.ReadLine();
            string Gend = Console.ReadLine();
            int DOB = Convert.ToInt32(Console.ReadLine());
            string Prov = Console.ReadLine();

            // Print the value of the variable User Input, which will display the input value
            Console.WriteLine("Your ID is: " + ID);
            Console.WriteLine("Surname is: " + SurN);
            Console.WriteLine("First Name is: " + FirstName);
            Console.WriteLine("Your Gender is: " + Gend);
            Console.WriteLine("The Date of birth is on: " + DOB);
            Console.WriteLine("They province that you're live is: " + Prov);
<<<<<<< Updated upstream
=======

            //Changes
            //Hello 
>>>>>>> Stashed changes
        }
    }
}
