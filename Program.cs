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
            int birthmonth = Convert.ToInt32(Console.ReadLine();

            Console.WriteLine("what is your favorite ROYGBIV color? Type 'help' for color list");

            if (Console.ReadLine() == "help")
            {
                Console.WriteLine("R=Red, O=Orange, Y=Yellow, G=Green, B=Blue, I=Indigo, V=Violet: Select one to continue.");
            }

            String color = Console.ReadLine();

            Console.WriteLine("How many siblings do you have?");
            int siblings = Convert.ToInt16(Console.ReadLine());

     //Conditon for Age Results

            if (age >= 55)
            {
                retireYears = 10;
            }

            else 

            if (age < 55)
            {
                retireYears = 20;
            }

            //Condition for Sibling Results

            if (siblings == 0)
            {
                location = San Juan; }

            else

            if (siblings == 1)
            {
                location = West Palm;
            }
            
            else 
            
            if (siblings == 2)
            {
                location = king, Georgia;
            }
                
            else 
            
            if (siblings >= 3)
            {
                location = East Cleveland;
            }
                
            //Condition for Color Results

           if (color == Red)
            {
                modeOfTransportation = Maserati;
            }
                                     
           else 
           
           if (color == Orange)
            {
                modeOfTransportation = Stallion;
            }

           else
            
            if (color == Yellow)
            {
                modeOfTransportation = Chariot;
            }

            else
            
            if (color == Green)
            {
                modeOfTransportation = Taxi;
            }

            else
            
            if (color == Blue)
            {
                modeOfTransportation = Rickshaw;
            }

            else 
            
            if (color == Indigo)
            {
                modeOfTransportation = Scooter;
            }

            else

            if (color == Violet)
            {
                modeOfTransportation = Flying Saucer;
                            }
        
            //Condition for Birth Month results

            if (birthmonth >= 0 && birthmonth <= 4)
            {
                bankBalance = 256000.76;
            }

            else

            if (birthmonth >= 8 && birthmonth <= 5)
            {
                bankBalance = 3687105.42;
            }

            else

            if (birthmonth >= 9 && birthmonth <= 12)
            {
                bankBalance = 86.23;
            }

            else
                bankBalance = 0.00;

           //User's Fortune results

            Console.Write(firstname + " " + lastname + " ");
            Console.Write("Will retire in" + retireYears);
            Console.Write(bankBalance);
            Console.Write("A vacation home in" + location);
            Console.Write("Travel mode by" + modeOfTransportation);
            Console.Write();
            Console.ReadKey();
            
        }
    }
}
