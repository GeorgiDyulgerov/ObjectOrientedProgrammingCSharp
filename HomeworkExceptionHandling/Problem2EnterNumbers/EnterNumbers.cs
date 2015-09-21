using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem2EnterNumbers
{
    class EnterNumbers
    {
        public static int i=0;

        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int inputcount = 10;
            int check=0;
            
            
            Console.WriteLine("Enter {0} numbers in range[{1}...{2}].",inputcount,start,end);
            for (i = 0; i < inputcount; i++)
            {
                int numbers=ReadNumber(start, end);
                if (i>0)
                {
                    try
                    {
                        if (check > numbers)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Invalid input!Number should be in range[{0}...{1}]!", check, end);
                        i--;
                        continue;
                    }
                    
                }
                check = numbers;
                if (i<inputcount-1)
                {
                    Console.WriteLine("Enter next number in range[{0}...{1}].",check,end);
                }
                
            }

        }

       private static int ReadNumber(int start, int end)
       {
           int number = 0;
           
           try
           {
               if (start >= end)
               {
                   throw new ArgumentException();
               }
               number = int.Parse(Console.ReadLine());

               if (number < start || number > end)
               {
                   throw new ArgumentOutOfRangeException();
               }

           }
           catch (ArgumentOutOfRangeException)
           {
               Console.WriteLine("Invalid input!Number should be in range[{0}...{1}]!",start,end);
               i--;
           }
           catch (ArgumentException)
           {
               Console.WriteLine("Invalid input! Start shoud be smaller then End!");
               i--;
           }
           catch (FormatException)
           {
               Console.WriteLine("Invalid input! Data must be integer number!");
               i--;
           }

           return number;
        }
    }
    
    
}
