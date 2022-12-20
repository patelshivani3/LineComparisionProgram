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
           
            //UC1 Length of the line
            Console.WriteLine("Please Enter The X1 & Y1 Co-Ordinates:");
            var X1 = Convert.ToDouble(Console.ReadLine());
            var Y1 = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Please Enter The X2 & Y2 Co-Ordinates:");
            var X2 = Convert.ToDouble(Console.ReadLine());
            var Y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter X3 & Y3 Co-Ordinates:");
            var X3 = Convert.ToDouble(Console.ReadLine());
            var Y3 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Please Enter X4 & Y4 Co-Ordinates:");
            var X4 = Convert.ToDouble(Console.ReadLine());
            var Y4 = Convert.ToDouble(Console.ReadLine());
           
            double X = Math.Pow((X2 - X1), 2);
            double Y = Math.Pow((Y2 - Y1), 2);
            double firstLineLength = Math.Sqrt(X + Y);
            Console.WriteLine("Length Of First Line is :" + firstLineLength);
            
            double x = Math.Pow((X4 - X3), 2);
            double y = Math.Pow((Y4 - Y3), 2);
            double secondLineLength = Math.Sqrt(x + y);
            Console.WriteLine("Length Of Second Line is :" + secondLineLength);
            
            if (firstLineLength == secondLineLength)
            {
                Console.WriteLine("Lines are Equal");
            }
            else if(firstLineLength > secondLineLength)
            {
                Console.WriteLine("First line is Greater than Second line");
            }
            else if (firstLineLength < secondLineLength)
            {
                Console.WriteLine("First line is Smaller than Second line");
            }
            Console.ReadLine();
        }
        

    }
}
