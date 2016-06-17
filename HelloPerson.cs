using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPerson
{
    class Program
    {
        static void PrintSpaces(int i)
        {
            for(; i>=0; --i)
            {
                Console.Write(" ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);

            Console.WriteLine("Please enter a number in range 1-10:");
            string user_response = Console.ReadLine();
            int num = int.Parse(user_response);

            while ( num<1 || num>10) //Check if the number in range 1-10
            {
                Console.WriteLine("The number is not in range 1-10");
                Console.WriteLine("Please enter a number in range 1-10:");
                user_response = Console.ReadLine();
                num = int.Parse(user_response);
            }
            
            
            for(int i=0; i<num; ++i)
            {
                Program.PrintSpaces(i);
                Console.WriteLine("{0}", name);
            }
        }
    }
}
