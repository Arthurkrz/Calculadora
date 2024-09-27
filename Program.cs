using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Bem vindo à calculadora!\n\nSelecione a operação a ser realizada:\n" +
                "1 - Soma;\n2 - Subtração;\n3 - Multiplicação;\n4 - Divisão;\n5 - Raíz quadrada;\n6 - Sair.");
                if (Enum.TryParse<Menu>(Console.ReadLine(), true, out Menu menu))
                {
                    switch (menu)
                    {
                        case Menu.Soma:
                            Calculadora.Soma();
                            break;
                        case Menu.Subtracao:
                            Calculadora.Subtracao();
                            break;
                        case Menu.Multiplicacao:
                            Calculadora.Multiplicacao();
                            break;
                        case Menu.Divisao:
                            Calculadora.Divisao();
                            break;
                        case Menu.RaízQuadrada:
                            Calculadora.Raiz();
                            break;
                        case Menu.Sair:
                            Console.Clear();
                            Console.WriteLine("Obrigado por utilizar nosso sistema de Calculadora!");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Resposta inválida. |");
                            Console.WriteLine(new string('-', 20));
                            Console.WriteLine("");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Resposta inválida. |");
                    Console.WriteLine(new string('-', 20));
                    Console.WriteLine("");
                }
            }
        }
    }
}
