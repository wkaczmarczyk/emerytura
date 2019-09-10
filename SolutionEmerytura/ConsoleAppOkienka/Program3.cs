using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleAppOkienka
{
    class Program3
    {
        const int wiekEmerytalny = 60;
        static void Main(string[] args)
        {
            Interaction.MsgBox("Aplikacja EMERYTURA");
                        
            string imie = Interaction.InputBox("Podaj imie");

            Console.WriteLine($"Witaj {imie}");

            Console.WriteLine("Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());
            if (wiek < wiekEmerytalny)

            {
                Console.WriteLine($"Zostało Ci {wiekEmerytalny - wiek} lat do emerytury");
            }
            else
            {
                Console.WriteLine("Jesteś emerytem");
            }

            // Console.ReadKey(); 
        }
    }
}
