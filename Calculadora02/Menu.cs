using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora02
{
    public class Menu
    {
        public static void Lista()
        {
            Console.WriteLine("Calculadora");

            Dictionary<int, string> Menu = new Dictionary<int, string>
            {
                { 1, "Soma" },
                { 2, "Subtracao" },
                { 3, "Multiplicacao" },
                { 4, "Divisao" },
                { 5, "Sair" }
            };

            foreach (var menu in Menu)
            {
                Console.WriteLine($"{ menu.Key} - { menu.Value }");
            }

        }
    }
}
