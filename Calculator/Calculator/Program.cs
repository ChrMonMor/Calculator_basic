using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a = 0;                                  // First number
            string b = "";                                 // Opperator
            double c = 0;                                  // Seccond number
            double d = 0;                                  // result
            bool end = true;
            while (end)
            {
                //-- checks if there has been a calculation before, by seening if a opperator has been used
                if (b == "")
                {
                    a = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    a = d;
                    Console.WriteLine(a);
                }
                b = Console.ReadLine();
                c = Convert.ToDouble(Console.ReadLine());

                //-- A Switch that calls the method we need, dependt on the opperator used
                switch (b)
                {
                    case "+":
                        d = Adds(a, c);
                        break;
                    case "-":
                        d = Subtracks(a,c);
                        break;
                    case "*":
                        d = Multiples(a,c);
                        break;
                    case "/":
                        d = Divides(a,c);
                        break;
                    case "^":
                        d = ToThePowerOf(a, c);
                        break;
                    default:
                        break;
                }
                
                //-- If the user wanna end the program, they answer yes here
                Console.WriteLine(d+"\nWanna End it here? (Yes/No):");
                end = CheckForEnd(Console.ReadLine());

            }
        }
        // Adds two numbers togther
        public static double Adds(double a, double c) => a + c;
        // Subtracks two numbers
        public static double Subtracks(double a, double c) => a - c;
        // Divides two numbers
        public static double Divides(double a, double c) => a / c;
        // Multiples two numbers
        public static double Multiples(double a, double c) => a * c;
        // To the power of two numbers
        public static double ToThePowerOf(double a, double c) => Math.Pow(a, c);

        // Ends the main While-loop if the user writes "end" at the end of a calculation
        public static bool CheckForEnd(string end)
        {
            bool endProgram = true;
            if (end == "Yes" || end == "yes" || end == "y")
                endProgram = false;
            return endProgram;
        } 

    }
}
