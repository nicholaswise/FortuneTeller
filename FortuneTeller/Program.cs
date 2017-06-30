using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the FORTUNE TELLER \nPress Enter to proceed");
            Console.ReadKey();

            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            Console.Write("Please enter your birth month in numeric form (1-12): ");
            int userBirthMonth = int.Parse(Console.ReadLine());

            Console.Write("Please enter your favorite color from ROYGBIV \n(What is ROYGBIV? Type \"Help\": ");
            string userColor = Console.ReadLine();
            string userHelp = ("Help");
            if (userColor == userHelp)
            {
                Console.Write("\nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolet\n\nEnter Color: \a");
            }
                string userColorHelp = Console.ReadLine(); //userColorHelp comes after user types Help for colors displayed

            Console.Write("Please enter the number of siblings you have: ");
            int userSibling = int.Parse(Console.ReadLine());

            Console.Write("Thank you for your submission! \nPress enter to see your future!");
            Console.ReadKey();

            //Start conditionals for variables

            //Conditional for user age
            if (userAge % 2 != 0)
            {
                Console.Write("You will retire in 20 years \n");
            }
            else if (userAge % 2 == 0)
            {
                Console.Write("You will retire in 30 years \n");
            }

            //Conditional for user birth month
            if (userBirthMonth >= 1 && userBirthMonth <= 4)
            {
                Console.Write("You will have $20,000 in the bank\n");
            }
            else if (userBirthMonth >= 5 && userBirthMonth <= 8)
            {
                Console.Write("You will have $50,000 in the bank\n");
            }
            else if (userBirthMonth >= 9 && userBirthMonth <= 12)
            {
                Console.Write("You will have $75,000 in the bank\n");
            }
            else
            {
                Console.Write("You will have $0 in the bank\n");
            }

            //Conditional for favorite color

            if (userColor == "Red")
            {
                Console.Write("You will drive a 1997 Toyota 4Runner\n");
            }
            else if (userColor == "Orange")
            {
                Console.Write("You will drive an exact replica of the Batmobile\n");
            }
            else if (userColor == "Yellow")
            {
                Console.Write("You will drive a Maserati\n");
            }
            else if (userColor == "Green")
            {
                Console.Write("You will drive a neon gree Lincoln Town Car\n");
            }
            else if (userColor == "Blue")
            {
                Console.Write("You will forever live on a sailboat with no cabin\n");
            }
            else if (userColor == "Indigo")
            {
                Console.Write("You will fly John Travolta's airplane to and from his house\n");
            }
            else if (userColor == "Violet")
            {
                Console.Write("You will hang around public parks and try and ride people's kites\n");
            }
            else
            {
                Console.Write("You will have no means of travel\n");
            }

            //Conditional for number of siblings


               


        }
    }
}
