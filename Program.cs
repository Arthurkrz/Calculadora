using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica c = new CalculadoraCientifica();
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Bem vindo à calculadora!\n\nSelecione a operação a ser realizada:\n" +
                "1 - Soma;\n2 - Subtração;\n3 - Multiplicação;\n4 - Divisão;\n5 - Raíz quadrada;\n6 - Sair.");
                int escolhaInicio = int.Parse(Console.ReadLine());
                switch (escolhaInicio)
                {
                    case 1:
                        bool loop1 = true;
                        while (loop1)
                        {
                            Console.WriteLine("Digite, linha a linha, o primeiro e o segundo número a ser somado (X - Y):");
                            int n1 = int.Parse(Console.ReadLine());
                            int n2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Resultado - {c.Soma(n1, n2)}.");
                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("");
                            bool loop12 = true;
                            while (loop12)
                            {
                                Console.WriteLine("Deseja realizar outra soma ('s'/'n')?");
                                string escolha = Console.ReadLine();
                                if (escolha == "n")
                                {
                                    Console.Clear();
                                    loop1 = false;
                                    loop12 = false;
                                }
                                else if (escolha == "s")
                                {
                                    Console.Clear();
                                    loop12 = false;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Resposta inválida.");
                                    Console.WriteLine(new string('-', 50));
                                    Console.WriteLine("");
                                }
                            }
                        }
                        break;
                    case 2:
                        bool loop2 = true;
                        while (loop2)
                        {
                            Console.WriteLine("Digite, linha a linha, o primeiro e o segundo número a ser subtraído:");
                            int n1 = int.Parse(Console.ReadLine());
                            int n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Resultado - {c.Subtracao(n1, n2)}.");
                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("");
                            bool loop22 = true;
                            while (loop22)
                            {
                                Console.WriteLine("Deseja realizar outra subtração ('s'/'n')?");
                                string escolha2 = Console.ReadLine();
                                if (escolha2 == "n")
                                {
                                    Console.Clear();
                                    loop2 = false;
                                    loop22 = false;
                                }
                                else if (escolha2 == "s")
                                {
                                    Console.Clear();
                                    loop22 = false;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Resposta inválida.");
                                    Console.WriteLine(new string('-', 50));
                                    Console.WriteLine("");
                                }
                            }
                        }
                        break;
                    case 3:
                        bool loop3 = true;
                        while (loop3)
                        {
                            Console.WriteLine("Digite, linha a linha, o primeiro e o segundo número a ser multiplicado:");
                            int n1 = int.Parse(Console.ReadLine());
                            int n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Resultado - {c.Multiplicacao(n1, n2)}.");
                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("");
                            bool loop32 = true;
                            while (loop32)
                            {
                                Console.WriteLine("Deseja realizar outra multiplicação ('s'/'n')?");
                                string escolha3 = Console.ReadLine();
                                if (escolha3 == "n")
                                {
                                    Console.Clear();
                                    loop3 = false;
                                    loop32 = false;
                                }
                                else if (escolha3 == "s")
                                {
                                    Console.Clear();
                                    loop32 = false;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Resposta inválida.");
                                    Console.WriteLine(new string('-', 50));
                                    Console.WriteLine("");
                                }
                            }
                        }
                        break;
                    case 4:
                        bool loop4 = true;
                        while (loop4)
                        {
                            Console.WriteLine("Digite, linha a linha, o primeiro e o segundo número a ser multiplicado:");
                            double n1 = double.Parse(Console.ReadLine());
                            double n2 = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Resultado - {c.Divisao(n1, n2)}.");
                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("");
                            bool loop42 = true;
                            while (loop42)
                            {
                                Console.WriteLine("Deseja realizar outra divisão ('s'/'n')?");
                                string escolha4 = Console.ReadLine();
                                if (escolha4 == "n")
                                {
                                    Console.Clear();
                                    loop4 = false;
                                    loop42 = false;
                                }
                                else if (escolha4 == "s")
                                {
                                    Console.Clear();
                                    loop42 = false;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Resposta inválida.");
                                    Console.WriteLine(new string('-', 50));
                                    Console.WriteLine("");
                                }
                            }
                        }
                        break;
                    case 5:
                        bool loop5 = true;
                        while (loop5)
                        {
                            Console.WriteLine("Digite o número a ser cuja raiz quadrada será calculada:");
                            double n = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Resultado - {c.Raiz(n)}.");
                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("");
                            bool loop52 = true;
                            while (loop52)
                            {
                                Console.WriteLine("Deseja realizar outro cálculo ('s'/'n')?");
                                string escolha5 = Console.ReadLine();
                                if (escolha5 == "n")
                                {
                                    Console.Clear();
                                    loop5 = false;
                                    loop52 = false;
                                }
                                else if (escolha5 == "s")
                                {
                                    Console.Clear();
                                    loop52 = false;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Resposta inválida.");
                                    Console.WriteLine(new string('-', 50));
                                    Console.WriteLine("");
                                }
                            }
                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Obrigado por utilizar a calculadora!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida.");
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}
