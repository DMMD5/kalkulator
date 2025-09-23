using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double elso;
            double masodik;
            string muvelet;

            Console.Write("Add meg az első számot: ");
            elso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a második számot: ");
            masodik = Convert.ToDouble(Console.ReadLine());

            Console.Write("Adjon meg egy műveleti jelet (+,-,*,/): ");
            muvelet = Convert.ToString(Console.ReadLine());

            switch (muvelet)
            {
                case "+":
                    Console.WriteLine($"A megoldás: {elso + masodik}");
                    break;

                case "-":
                    Console.WriteLine($"A megoldás: {elso - masodik}");
                    break;

                case "*":
                    Console.WriteLine($"A megoldás: {elso * masodik}");
                    break;

                case "/":
                    Console.WriteLine($"A megoldás: {elso / masodik}");
                    break;
                default:
                    Console.WriteLine("Hibás művelet");
                    break;

            }

            



            
        }
    }
}
