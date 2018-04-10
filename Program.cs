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
                Console.WriteLine("ENTER NAME OF NEW PERSON BELOW");
                Console.WriteLine("");
            
                Console.Write(">> First Name: ");
                var fname_input = Console.ReadLine();
                Console.Write(">> Last Name: ");
                var lname_input = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Creating new person record...");

                var user = new Person(fname_input, lname_input);
                
                Console.WriteLine("");
                Console.Write(">>  Enter year of Birth: ");
                user.YearOfBirth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine(user.GetFullName());
                Console.WriteLine("");
                Console.Write("Do you want to enter another person? <Y/N>: ");
                var response = Console.ReadLine();
                response.ToUpper();

                if (response == "n" || response == "N")
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
