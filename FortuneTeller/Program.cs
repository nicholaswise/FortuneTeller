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
            string firstNameAny = firstName.ToLower();
            if (firstNameAny == "quit")
            {
                Console.Write("Nobody likes a quitter!\n");
                Environment.Exit(0);
            }

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            string lastNameAny = lastName.ToLower();
            if (lastNameAny == "quit")
            {
                Console.Write("Nobody likes a quitter!\n");
                Environment.Exit(0);
            }

            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();
            string userAgeString = userAge.ToLower();
            if (userAgeString == "quit")
            {
                Console.Write("Nobody likes a quitter!\n");
                Environment.Exit(0);
            }
            int userAgeInt = Convert.ToInt32(userAge);

            Console.Write("Please enter your birth month(1-12): ");
            string userBirthMonth = Console.ReadLine();
            string userBirthMonth1 = userBirthMonth.ToLower();
            if (userBirthMonth1 == "quit")
            {
                Console.Write("Nobody likes a quitter!\n");
                Environment.Exit(0);
            }
            int userBirthMonthInt = Convert.ToInt32(userBirthMonth1);

            Console.Write("Please enter your favorite color from ROYGBIV \nWhat is ROYGBIV? Type \"Help\": ");
            string userColors = Console.ReadLine();
            string userColor = userColors.ToLower();
            if (userColor == "quit")
            {
                Console.Write("Nobody likes a quitter!\n");
                Environment.Exit(0);
            }
            if (userColor == "help")
            
                Console.Write("\nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolet\n\nEnter Color: \a");

                string userHelp = (Console.ReadLine());
                string userHelp1 = userHelp.ToLower();

                if (userHelp1 == "quit")
                {
                    Console.Write("Nobody likes a quitter!\n");
                    Environment.Exit(0);
                }
       

            Console.Write("Please enter the number of siblings you have: ");
            string userSibling = Console.ReadLine();
            string userSiblings = userSibling.ToLower();
            if (userSiblings == "quit")
            {
                Console.Write("Nobody likes a quitter!\n");
                Environment.Exit(0);
            }
            int userSiblingInt = Convert.ToInt32(userSiblings);

            Console.Write("Thank you for your submission! \nPress enter to see your future!\n\n");
            Console.ReadKey();

            Console.Write(firstName + " ");
            Console.Write(lastName);

            //Start conditionals for variables

            //Conditional for retiring years

            if (userAgeInt % 2 != 0)
            {
                Console.Write(" will retire in 20 years");
            }
            else if (userAgeInt % 2 == 0)
            {
                Console.Write(" will retire in 30 years");
            }

            //Conditional for money in the bank

            if (userBirthMonthInt >= 1 && userBirthMonthInt <= 4)
            {
                Console.Write(" with $50,000 in the bank,");
            }
            else if (userBirthMonthInt >= 5 && userBirthMonthInt <= 8)
            {
                Console.Write(" with $100,000 in the bank,");
            }
            else if (userBirthMonthInt >= 9 && userBirthMonthInt <= 12)
            {
                Console.Write(" with $500,000 in the bank,");
            }
            else
            {
                Console.Write(" with $0 in the bank,");
            }

            //Conditional for vacation home

            if (userSiblingInt == 0)
            {
                Console.Write(" a vacation home on a mountain in Colorado,");
            }
            else if (userSiblingInt == 1)
            {
                Console.Write(" a vacation home in the Lofoten Islands off the coast of Norway,");
            }
            else if (userSiblingInt == 2)
            {
                Console.Write(" a vacation home in New York City,");
            }
            else if (userSiblingInt == 3)
            {
                Console.Write(" a vactaion home in Iceland,");
            }
            else
            {
                Console.Write(" a vacation home in New Jersey,");
            }

            //Conditional for means of travel

            if (userColor == "red" || userHelp1 == "red")
            {
                Console.Write(" and will drive a 1997 Toyota 4Runner.\n");
            }
            else if (userColor == "orange" || userHelp1 == "orange")
            {
                Console.Write(" and will drive an exact replica of the Batmobile.\n");
            }
            else if (userColor == "yellow" || userHelp1 == "yellow")
            {
                Console.Write(" and will drive a Maserati.\n");
            }
            else if (userColor == "green" || userHelp1 == "green")
            {
                Console.Write(" and will drive a blacked out Lincoln Town Car.\n");
            }
            else if (userColor == "blue" || userHelp1 == "blue")
            {
                Console.Write(" and will drive the Mystery Machine.\n");
            }
            else if (userColor == "indigo" || userHelp1 == "indigo")
            {
                Console.Write(" and will fly an airplane to every occasion.\n");
            }
            else if (userColor == "violet" || userHelp1 == "violet")
            {
                Console.Write(" and will hang around public parks and try and ride people's kites.\n");
            }
            else
            {
                Console.Write(" and will have no means of travel.\n");
            }

            //[First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].

        }
    }
}
