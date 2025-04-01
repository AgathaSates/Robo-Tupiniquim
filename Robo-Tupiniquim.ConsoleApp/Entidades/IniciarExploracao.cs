using Robo_Tupiniquim.ConsoleApp.Utilitários;

namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class IniciarExploracao
{
    public static void Explorar()
    {
        Robo robo1 = new Robo();
        Robo robo2 = new Robo();

        EscrevaExploracao.TituloIniciodaMissao();
        Area.PedirArea();

        robo1.PedirDados();
        robo2.PedirDados();
        
        EscrevaExploracao.MensagemInicioDaMissao();

        robo1.MoverRobo();
        Thread.Sleep(1500);

        robo2.MoverRobo();
        Thread.Sleep(1500);

        EscrevaExploracao.StatusFinaldaMissao();
        Console.ReadKey();
    }
}
