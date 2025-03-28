using Robo_Tupiniquim.ConsoleApp.Entidades;
using Robo_Tupiniquim.ConsoleApp.Entidades.Utilitários;

namespace Robo_Tupiniquim.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        do 
        {
            Area.Area_();
            Robo.Robo01();
            Robo.Robo02();
        } while (EscrevaInteracao.Explorarnovamente());

    }
}
