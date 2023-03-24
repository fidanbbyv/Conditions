using static System.Console;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            WriteLine("Enter your department");
            string department = ReadLine();

            if (department == "hr" || department == "Hr" || department == "HR")
            {
                WriteLine("Insan Resurslari sobesi");
            }

            else if (department == "ıt" || department == "It" || department == "IT")
            {
                WriteLine("Informasiya Texnologiyalari sobesi");
            }

            else if (department == "finance" || department == "Finance")
            {
                WriteLine("Finans sobesi");
            }

            else
            {
                WriteLine("Bele bir sobe yoxdur");
            }


            //Task 2

            WriteLine("How many years of experience do you have?");
            int experience = Convert.ToInt32(ReadLine());

            if (experience >= 0 && experience <= 2)
            {
                WriteLine("Your salary is 2000");
            }
            else if (experience > 2 && experience <= 5)
            {
                WriteLine("Your salary is 5000");
            }
            else if (experience > 5 && experience <= 10)
            {
                WriteLine("Your salary is 7000");
            }
            else
            {
                WriteLine("Your salary is 10000");
            }
        }
    }
}