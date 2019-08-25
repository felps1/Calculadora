using System;
using System.Collections.Generic;

namespace Calculadora02
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Lista();

            bool aberto = true;

            while (aberto)
            {
                Console.WriteLine("Digite a operacao desejada: ");
                decimal operacao = LeiaNumero();

                switch (operacao)
                {
                    case 1:
                        soma();
                        break;
                    case 2:
                        subtracao();
                        break;
                    case 3:
                        multiplicacao();
                        break;
                    case 4:
                        divisao();
                        break;
                    case 5:
                        aberto = false;
                        break;
                }

            }
            Console.ReadLine();
        }

        private static void soma()
        {
            decimal num1 = PegarNumero();
            decimal num2 = PegarNumero();
            Console.WriteLine($"O resultado é {num1 + num2}");
        }

        private static void subtracao()
        {
            decimal num1 = PegarNumero();
            decimal num2 = PegarNumero();
            Console.WriteLine($"O resultado é {num1 - num2}");
        }

        private static void multiplicacao()
        {
            decimal num1 = PegarNumero();
            decimal num2 = PegarNumero();
            Console.WriteLine($"O resultado é {num1 * num2}");
        }

        private static void divisao()
        {
            decimal num1 = PegarNumero();
            decimal num2 = PegarNumero();
            Console.WriteLine($"O resultado é {num1 / num2}");
        }

        private static decimal LeiaNumero()
        {
            string txt = Console.ReadLine();
            return Convert.ToDecimal(txt);
        }

        private static decimal PegarNumero()
        {
            Console.WriteLine("Digite o numero desejado: ");
            string input = Console.ReadLine();
            return Convert.ToDecimal(input);
        }


    }
}
