using System;
using static Ivory.TesteEstagio.CampoMinado.CampoMinado;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!
            while (campoMinado.JogoStatus == (int)StatusTipo.Aberto)
            {

                 Console.WriteLine("Informe a linha:");
                int linha = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a coluna:");
                int coluna = int.Parse(Console.ReadLine());

                campoMinado.Abrir(linha, coluna);
                Console.Clear();
                Console.WriteLine(campoMinado.Tabuleiro);
               

            }

            if (campoMinado.JogoStatus == (int)StatusTipo.Vitoria)
                Console.WriteLine("Parabéns, você venceu!");
            else if (campoMinado.JogoStatus == (int)StatusTipo.GameOver)
                Console.WriteLine("Você Perdeu!");

        }
    }
}
