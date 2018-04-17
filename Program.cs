using System;

namespace Prog_3
{
    class Program
    {
        static void Main(string[] args)
        {
             //Start the program with Clear();
            Console.Clear();
            
            var keepgoing = true;

            do
            {
                Console.WriteLine("ENTER NAME OF NEW PERSON BELOW \n");
                Console.Write(">> First Name: ");
                var fname_input = Console.ReadLine();
                Console.Write(">> Last Name: ");
                var lname_input = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Creating new person record... \n");

                var user = new Person(fname_input, lname_input);

                Console.WriteLine(user.GetFullName());
                
                Console.Write(">>  Enter year of Birth: ");
                var birth_input = Console.ReadLine();
                int birth_year = 0;
                if (!int.TryParse(birth_input, out birth_year))
                {
                    Console.WriteLine("You didn't enter a number!. The program will now close!");
                    Environment.Exit(0);
                    
                }
                else 
                {
                    user.YearOfBirth = birth_year;

                }
                
                Console.WriteLine(user.PersonInfo());

                Console.Write("Do you want to enter another person? <Y/N>: \n");
                var response = Console.ReadLine();
                
                var responseLower = response?.ToUpper();

                if (responseLower == "N")
                {
                    keepgoing = false;

                //End the program with blank line and instructions
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Press <Enter> to quit the program");
                Console.ReadKey();
                }


            } while (keepgoing == true);

            Console.ReadLine();
        }
    }
}
