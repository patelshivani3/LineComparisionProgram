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
            
            double X = Math.Pow((X2 - X1), 2);
            double Y = Math.Pow((Y2 - Y1), 2);
            
            double lineLength = Math.Sqrt(X + Y);
            Console.WriteLine("Length Of Line is :" + lineLength);
            Console.ReadLine();
        }
        

    }
}
