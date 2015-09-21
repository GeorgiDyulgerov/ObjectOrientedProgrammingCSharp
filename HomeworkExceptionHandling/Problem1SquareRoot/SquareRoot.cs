using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem1SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter an integer number: ");
                uint number = uint.Parse(Console.ReadLine());
                Console.WriteLine("Square Root is: {0:##.##}", Math.Sqrt(number));
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number!The number shoud be in range[0...{0}]", int.MaxValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Data must be integer number!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
