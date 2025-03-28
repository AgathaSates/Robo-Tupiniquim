using Robo_Tupiniquim.ConsoleApp.Entidades;
using Robo_Tupiniquim.ConsoleApp.Utilitários;

namespace Robo_Tupiniquim.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Title = "Desbrave Marte";
            EscrevaMenu.Titulo();
            EscrevaMenu.Menu();
            int opcaomenu = Convert.ToInt32(Console.ReadLine());
            switch (opcaomenu)
            {
                case 1: IniciarExploracao.Explorar(); break;

                case 2: EscrevaMenu.Treinamento(); break;

                case 3: HistoricodeExploracao.MostrarHistorico(); break;

                case 4: EscrevaMenu.Desconectar(); return;

            }
        }       
    }
}
