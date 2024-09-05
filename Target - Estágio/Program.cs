using System;
using System.Linq;

namespace Target_Sistemas
{
    class Target_Sistemas
    {
        void PertenceFibonacci(int inputUsuario)
        {

            if (inputUsuario <= 1)
            {
                Console.WriteLine($"O número {inputUsuario} pertence à sequência de Fibonacci.");
                return;
            }


            int primeiroAntecessor = 1, segundoAntecessor = 0, subsequente;

            while (primeiroAntecessor < inputUsuario)
            {
                subsequente = primeiroAntecessor + segundoAntecessor;
                segundoAntecessor = primeiroAntecessor;
                primeiroAntecessor = subsequente;
            }

            if (primeiroAntecessor == inputUsuario)
            {
                Console.WriteLine($"O número {primeiroAntecessor} pertence à sequência de Fibonacci.");
                return;
            }

            Console.WriteLine($"O número {inputUsuario} não pertence à sequência de Fibonacci.");

        }

        void VerificaLetraA(string inputUsuario)
        {
            inputUsuario = inputUsuario.ToLower();

            if (inputUsuario.Contains('a'))
            {
                int quantidadeA = inputUsuario.Count(x => x == 'a');
                Console.WriteLine($"A letra 'a' existe na string e aparece {quantidadeA} {(quantidadeA == 1 ? "vez" : "vezes")}.");
                return;
            }

            Console.WriteLine("A letra 'a' não existe na string.");
        }

        static void Main(string[] args)
        {
            Target_Sistemas ts = new Target_Sistemas();
            Menu menu = new Menu();

            while (true)
            {
                menu.Cabecalho("Target Sistemas - Processo Seletivo");

                var opcao = menu.Main(["Verificar se pertence à sequência Fibonacci", "Verificar letra 'a'", "Sair"]);
                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        menu.Cabecalho("Opção 1 - Fibonacci");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Informe um número: ");
                        Console.ResetColor();

                        if (int.TryParse(Console.ReadLine(), out int inputUsuario))
                        {
                            ts.PertenceFibonacci(inputUsuario);
                            break;
                        }

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entrada inválida! Por favor, insira um número válido.");
                        Console.ResetColor();
                        break;

                    case "2":
                        Console.Clear();
                        menu.Cabecalho("Opção 2 - Verificar Letra 'a'");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Informe uma string: ");
                        Console.ResetColor();

                        ts.VerificaLetraA(Console.ReadLine());
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Tem certeza de que deseja sair? (S/N): ");
                        Console.ResetColor();

                        var confirmacao = Console.ReadLine().ToUpper()[0];
                        Console.WriteLine();
                        if (confirmacao == 'S')
                        {
                            menu.Cabecalho("Saindo... Até logo!");
                            Thread.Sleep(2000);
                            return;
                        }

                        Console.Clear();
                        continue;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}