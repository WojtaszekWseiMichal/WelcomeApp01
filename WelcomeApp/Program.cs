using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace WelcomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string surrname = "";
            int age = 0;
            if (args.Length == 0)
            {
                Console.WriteLine("Hello, what's your name ?");
                name = Console.ReadLine();
                Console.WriteLine("What is your surrname ?");
                surrname = Console.ReadLine();
                Console.WriteLine("What is your age ?");
                age = Convert.ToInt32(Console.ReadLine());
            }
            if(args.Length == 1)
            {
                name = args[0];
                Console.WriteLine("What is your surrname ?");
                surrname = Console.ReadLine();
                Console.WriteLine("What is your age ?");
                age = Convert.ToInt32(Console.ReadLine());
            }
            if(args.Length == 2)
            {
                name = args[0];
                surrname = args[1];
                Console.WriteLine("What is your age ?");
                age = Convert.ToInt32(Console.ReadLine());
            }
            if(args.Length >= 3)
            {
                name = args[0];
                surrname = args[1];
                age = Convert.ToInt32(args[2]);
            }
            if (age < 67) Console.WriteLine("Hello {0} {1}. You are still working.", name, surrname);
            else if (age > 67) Console.WriteLine("Hello {0} {1}. You are pensioner already", name, surrname);
            else Console.Write("Wrong age");
            Console.ReadKey();
        }
    }
}
