using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to line comparision program ");
            LineComparision();
            Console.ReadLine();
        }
        public static void LineComparision()
        {
            //UC1 Length of the line
            Console.WriteLine("Please Enter The X1 & Y1 Co-Ordinates:");
            var X1 = Convert.ToDouble(Console.ReadLine());
            var Y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter The X2 & Y2 Co-Ordinates:");
            var X2 = Convert.ToDouble(Console.ReadLine());
            var Y2 = Convert.ToDouble(Console.ReadLine());

            double firstLineLength = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length Of First Line is :" + firstLineLength);
            
            //UC2 second line
            Console.WriteLine("Please Enter X3 & Y3 Co-Ordinates:");
            var X3 = Convert.ToDouble(Console.ReadLine());
            var Y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter X4 & Y4 Co-Ordinates:");
            var X4 = Convert.ToDouble(Console.ReadLine());
            var Y4 = Convert.ToDouble(Console.ReadLine());

            double secondLineLength = Math.Sqrt(Math.Pow((X4 - X3), 2) + Math.Pow((Y4 - Y3), 2));
            Console.WriteLine("Length Of Second Line is :" + secondLineLength);
            
            //UC4 Comparision using CompareTo Method
            int compare = firstLineLength.CompareTo(secondLineLength);
            Console.WriteLine("Comparision is :"+compare);
            // UC3 Equality of lines
            if (compare == 0)
            {
                Console.WriteLine("Lines are Equal");
            }
            else if (compare > 0)
            {
                Console.WriteLine("First line is Greater than Second line");
            }
            else 
            {
                Console.WriteLine("First line is Smaller than Second line");
            }
        }
    }
}
