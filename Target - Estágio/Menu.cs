using System;

namespace Target_Sistemas
{
    class Menu
    {
        string Linha(int tamanhoLinha = 52) { return new string('-', tamanhoLinha); }

        public void Cabecalho(string textoCabecalho)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Linha());
            Console.WriteLine(CentralizarTexto(textoCabecalho));
            Console.WriteLine(Linha());
            Console.ResetColor();
        }

        string CentralizarTexto(string texto, int totalCaracteres = 52)
        {
            int espacos = totalCaracteres - texto.Length;
            int padEsquerdo = espacos / 2;
            int padDireito = espacos - padEsquerdo;

            return new string(' ', padEsquerdo) + texto + new string(' ', padDireito);
        }

        public string Main(string[] opcoes)
        {
            Cabecalho("MENU PRINCIPAL");
            for (int i = 0; i < opcoes.Length; i++)
                Console.WriteLine($"\x1b[93m{i+1}\x1b[39m - \x1b[96m{opcoes[i]}\x1b[39m");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Sua opção: ");
            Console.ResetColor();
            var opcao = Console.ReadLine();
            return opcao;
        }

    }
}
