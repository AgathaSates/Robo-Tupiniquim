using Robo_Tupiniquim.ConsoleApp.Entidades;
using Robo_Tupiniquim.ConsoleApp.Entidades.Utilitários;

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
                case 1: IniciarMissao.Iniciar_Missao(); break;

                case 2: EscrevaMenu.Treinamento(); break;

                case 3: EscrevaMenu.Desconectar(); return;

            }
        }       
    }
}
