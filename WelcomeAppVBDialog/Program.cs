using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace WelcomeAppVBDialog
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string surrname = "";
            int age = 0;
            Interaction.MsgBox("Welcome app !", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Hey there !");
            if (args.Length == 0)
            {
                name = Interaction.InputBox("Podaj swoje imie", "");
                surrname = Interaction.InputBox("Podaj swoje nazwisko");
                age = Convert.ToInt32(Interaction.InputBox("What is your age ?"));
            }
            if (args.Length == 1)
            {
                name = args[0];
                surrname = Interaction.InputBox("Podaj swoje nazwisko");
                age = Convert.ToInt32(Interaction.InputBox("What is your age ?"));
            }
            if (args.Length == 2)
            {
                name = args[0];
                surrname = args[1];
                age = Convert.ToInt32(Interaction.InputBox("What is your age ?"));
            }
            if (args.Length >= 3)
            {
                name = args[0];
                surrname = args[1];
                age = Convert.ToInt32(args[2]);
            }
            if (age <= 67)
            {
                int toPension = 67 - age;
                Console.WriteLine("Hello {0} {1}. You should still working and need {2} to became pensioner", name, surrname, toPension);
            }
            else if (age > 67) Console.WriteLine("Hello {0} {1}. You are pensioner already", name, surrname);
            else Console.Write("Wrong age");
            Console.ReadKey();
        }
    }
    }
