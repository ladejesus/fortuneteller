using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name");
            string  firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string  lastname =  Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your birth month?");
            string  birthmonth = Console.ReadLine();

            Console.WriteLine("what is your favorite ROYGBIV color? Type 'help' for color list");

            if (Console.ReadLine() == "help")
            {
                Console.WriteLine("R=Red, O=Orange, Y=Yellow, G=Green, B=Blue, I=Indigo, V=Violet: Select one to continue.");
            }

            String color = Console.ReadLine();

            Console.WriteLine("How many siblings do you have?");
            int siblings = Convert.ToInt16(Console.ReadLine());

     //Conditon for Age Results

            if (age >= 55) {
                Console.WriteLine("Not long now");
            }

            else if (age < 55) {
                Console.WriteLine("Keep Working!!");
            }

     //Condition for Sibling Results
            if (siblings == 0)
                Console.WriteLine("San Juan, Puerto Rico");

            else if (siblings == 1)
                Console.WriteLine("West palm, Florida");

            else if (siblings == 2)
                Console.WriteLine("King, Georgia");

            else if (siblings >= 3)
                Console.WriteLine("East Cleveland, Ohio");

            //Condition for Color Results

            string Red = null;
            if (color == Red)
                Console.WriteLine("Maserati");

            string Orange = null;
            if (color == Orange)
                Console.WriteLine("Stallion");

            string Yellow = null;
            if (color == Yellow)
                Console.WriteLine("Chariot");

            string Green = null;
            if (color == Green)
                Console.WriteLine("Taxi");

            string Blue = null;
            if (color == Blue)
                Console.WriteLine("Rickshaw");

            string Indigo = null;
            if (color == Indigo)
                Console.WriteLine("Scooter");

            string Violet = null;
            if (color == Violet)
                Console.WriteLine("Flying Saucer");

            //Condition for Birth Month results

            if (birthmonth = 12)
                Console.WriteLine("\256,000.76");

            if(birthmonth )




                        //User's Fortune results
            Console.WriteLine("firstname");
            Console.WriteLine("lastname");
            Console.WriteLine(years)
            Console.WriteLine(bankbalance)
            
                }
    }
}
